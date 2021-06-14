--TO_DATE('17/12/2015', 'DD/MM/YYYY');
--convert(datetime,'18-06-12 10:34:09 PM',5)
--select * from RentalTransaction
--insert into RentalTransaction (dateBooked, expRetDate) values (convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'20-06-12 10:34:09 PM',5))
--select * from RentalTransaction where dateBooked > convert(datetime,'1-06-12 10:34:09 PM',5) and dateBooked < convert(datetime,'01-01-13 10:34:09 PM',5)


select * from Vehicle as V, VehicleType as T  where V.vTypeID = T.vTypeID and V.vehicleID not in 
(select rentedVID from RentalTransaction)

select * from Vehicle where Vehicle.vehicleID not in
(
select rentedVID from RentalTransaction where 
dateBooked > convert(datetime,'26-06-12 10:34:09 PM',5) and 
dateBooked < convert(datetime,'01-01-13 10:34:09 PM',5)
)

insert into Vehicle (milage, brand, model, [year], branchID, vTypeID) values (50000, 'Bugatti', 'Veyron', 2009, 1, 'Large');
insert into RentalTransaction (rentedVID, vTypeID, branchBorrow, branchReturn, dateBooked, expRetDate) values (1, 'Large', 1, 1, convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'25-06-12 10:34:09 PM',5))

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