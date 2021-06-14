--TO_DATE('17/12/2015', 'DD/MM/YYYY');
--convert(datetime,'18-06-12 10:34:09 PM',5)
--select * from RentalTransaction
--insert into RentalTransaction (dateBooked, expRetDate) values (convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'20-06-12 10:34:09 PM',5))
--select * from RentalTransaction where dateBooked > convert(datetime,'1-06-12 10:34:09 PM',5) and dateBooked < convert(datetime,'01-01-13 10:34:09 PM',5)

select R.rentalID, U.[UID], U.userName, R.rentedVID, V.brand, V.model, V.[year], R.dateBooked, R.expRetDate, R.branchBorrow, R.eBranchReturn
                from RentalTransaction as R, [User] as U, Vehicle as V
                where R.userID = U.[UID] and R.rentedVID = V.vehicleID and U.userName = 'admin' and R.aBranchReturn IS NULL

select * from Vehicle as V, VehicleType as T  where V.vTypeID = T.vTypeID and V.vehicleID not in 
(select rentedVID from RentalTransaction)

select * from Vehicle where Vehicle.vehicleID not in
(
select rentedVID from RentalTransaction where 
dateBooked > convert(datetime,'26-06-12 10:34:09 PM',5) and 
dateBooked < convert(datetime,'01-01-13 10:34:09 PM',5)
)

insert into Vehicle (milage, brand, model, [year], branchID, vTypeID) values (50000, 'Bugatti', 'Veyron', 2009, 1, 'Large');
insert into RentalTransaction (userID, rentedVID, vTypeID, branchBorrow, eBranchReturn, aBranchReturn, dateBooked, expRetDate) values (1, 1, 'Large', 1, 1, 2, convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'25-06-12 10:34:09 PM',5))

select * from RentalTransaction
select * from Vehicle as V, VehicleType as T where V.vTypeID = T.vTypeID and V.vehicleID not in 
(
select rentedVID from RentalTransaction where 
(dateBooked between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'12-06-21 10:34:09 PM',5)) or 
(expRetDate between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'12-06-21 10:34:09 PM',5)) or
(dateBooked > convert(datetime,'12-06-21 10:34:09 PM',5) and expRetDate < convert(datetime,'12-06-21 10:34:09 PM',5))
)

select * from Vehicle where branchID = 1 and vehicleID not in 
(
select rentedVID from RentalTransaction where 
(dateBooked between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'21-06-21 10:34:09 PM',5)) and 
(expRetDate between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'21-06-21 10:34:09 PM',5))
)

select * from Vehicle as V, RentalTransaction as R where V.vehicleID = R.rentedVID 
and dateBooked > convert(datetime,'01-06-21 10:34:09 PM',5) or expRetDate < convert(datetime,'01-06-21 10:34:09 PM',5)

select * from Branch
select * from [User]
select * from RentalTransaction
select * from Customer


select count(branchID) as branchCount from Branch as B, RentalTransaction as R 
where B.branchID = R.aBranchReturn and B.branchID != R.eBranchReturn
group by branchID


select * from Employee

-- You can change the max to min if you want a specific 
select B.branchID, max(temp.branchCount) as difBranchCount from Branch as B, 
(select count(branchID) as branchCount, branchID as BID from Branch as B, RentalTransaction as R, Customer as C 
where R.userID = C.customerID and B.branchID = R.aBranchReturn and B.branchID != R.eBranchReturn
and C.membership = 'Regular' group by branchID) as temp
where B.branchID = temp.BID and B.prov = 'AB' -- Switch prov to city and vice versa depending on what you want
group by B.branchID

-- Find the avg spending of either customers vs employees OR gold vs regular members of all branches 

-- Find each branch somehow
select branchID from Branch
-- For each branch, we grab the branch ID and get the dates + vehicle type (rates) of each rental transaction
select B.branchID, R.dateBooked, R.actRetDate, V.dRate, V.wRate, V.mRate from Branch as B, RentalTransaction as R, VehicleType as V
where B.branchID = R.branchBorrow and R.vTypeID = V.vTypeID
-- Note, is the customer a regular or gold member?


-- Use C# to find the amount of


select count(branchID) as branchCount from Branch as B, RentalTransaction as R 
where B.branchID = R.aBranchReturn and B.branchID != R.eBranchReturn
group by branchID