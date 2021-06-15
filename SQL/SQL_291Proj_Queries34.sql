-- QUERY 3
-- You can change the max to min if you want a specific 
select B.branchID, max(temp.branchCount) as difBranchCount from Branch as B, 
(select count(branchID) as branchCount, branchID as BID from Branch as B, RentalTransaction as R, Customer as C 
where R.userID = C.customerID and B.branchID = R.aBranchReturn and B.branchID != R.eBranchReturn
and C.membership = 'Regular' group by branchID) as temp
where B.branchID = temp.BID and B.prov = 'AB' -- Switch prov to city and vice versa depending on what you want
group by B.branchID

-- QUERY 4
select avg(R.amountPaid) as avgSpent from RentalTransaction as R, Customer as U
-- Change the membership and the aBranchReturn ID depending on the user's choice
where R.userID = U.customerID and U.membership = 'Gold' and R.aBranchReturn = 1 and
-- For each of these 3 date checks, the former is the FROM DATE and the latter is the TO DATE
(dateBooked between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'12-06-21 10:34:09 PM',5)) or 
(expRetDate between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'12-06-21 10:34:09 PM',5)) or
(dateBooked > convert(datetime,'12-06-21 10:34:09 PM',5) and expRetDate < convert(datetime,'12-06-21 10:34:09 PM',5))