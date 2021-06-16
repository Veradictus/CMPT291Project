--1)
SELECT (firstName + ' ' + lastName) AS userFullName FROM [User]
WHERE [UID] in (
            SELECT empBorrow FROM RentalTransaction 
            WHERE vTypeID='small' -- Here User specifies (small,medium,Large)
            GROUP BY empBorrow      --Here User specifies empRet or empBorrow
            HAVING COUNT(*) > 1);   --Here user specifies the number for X

--2)
SELECT * FROM [User] as U, Customer as C, RentalTransaction R1 
WHERE membership='Gold' AND R1.vTypeID='small' AND exists( --User will specify the type of member (Gold or Regular)
                                                            (SELECT vTypeID FROM VehicleType WHERE vTypeID='Large' AND vTypeID='medium') --"haven't used large
                                                            EXCEPT
                                                            (SELECT vTypeID FROM RentalTransaction as R
                                                             WHERE R.userID=C.customerID)) AND U.[UID]=C.customerID;


-- QUERY 3
-- You can change the max to min if you want a specific 
select B.branchID, max(temp.branchCount) as difBranchCount from Branch as B, 
(select count(B.branchID) as branchCount, B.branchID as BID from Branch as B, RentalTransaction as R, Customer as C 
where R.userID = C.customerID and B.branchID = R.aBranchReturn and B.branchID != R.eBranchReturn
and C.membership = 'Regular' group by branchID) as temp
where B.branchID = temp.BID and B.prov = 'AB' -- Switch prov to city and vice versa depending on what you want
group by B.branchID

select branchID from Branch
where prov = 'AB'


-- QUERY 4
select avg(R.amountPaid) as avgSpent from RentalTransaction as R, Customer as U
-- Change the membership and the aBranchReturn ID depending on the user's choice
where R.userID = U.customerID and U.membership = 'Gold' and R.aBranchReturn = 1;

select amountPaid from RentalTransaction where amountPaid is not null;
-- For each of these 3 date checks, the former is the FROM DATE and the latter is the TO DATE

--select avg(amountPaid) as avgSpent from RentalTransaction where 
select avg(amountPaid) as avgSpent from
((select amountPaid from RentalTransaction as R, Customer as C 
where R.userID = C.customerID and R.aBranchReturn = 1 and
C.membership = 'Gold' and amountPaid is not null)
intersect
(select amountPaid from RentalTransaction where
(convert(date,dateBooked) between convert(date,'1-06-21',5) and convert(date,'30-06-21',5)) or 
(convert(date,expRetDate) between convert(date,'1-06-21',5) and convert(date,'30-06-21',5)) or
(convert(date,dateBooked) > convert(date,'1-06-21',5) and convert(date,expRetDate) < convert(date,'30-06-21',5)))) as temp

-- NOTE ON QUERY 4
/*
The convert() methods are very important to get SQL to read the the correct times.
Preferably, in C#, when you're grabbing the date from a date-picker or whatever,
it is best to grab the string from the object itself using dateFrom.Value.ToString("G").
The G is the format that SQL seems to prefer.
*/