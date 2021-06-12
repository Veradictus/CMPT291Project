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
dateBooked > convert(datetime,'1-06-12 10:34:09 PM',5) and 
dateBooked < convert(datetime,'01-01-13 10:34:09 PM',5)
)

insert into Vehicle (milage, brand, model, [year], branchID, vTypeID) values (50000, 'Bugatti', 'Veyron', 2009, 1, 'Large');
insert into RentalTransaction (rentedVID, vTypeID, branchBorrow, branchReturn, dateBooked, expRetDate) values (1, 'Small', 1, 1, convert(datetime,'18-06-12 10:34:09 PM',5), convert(datetime,'20-06-12 10:34:09 PM',5))


select * from Vehicle as V, RentalTransaction as R where V.vehicleID = R.rentedVID and dateBooked > convert(datetime,'1-06-12 10:34:09 PM',5) and dateBooked < convert(datetime,'01-01-13 10:34:09 PM',5)

select * from Branch
select * from [User]
select * from RentalTransaction
select * from Customer

INSERT INTO [User] VALUES 
('test123', 'pass123', 'Customer', 'Male', 'Gerardo', 'Cea', 'Something', 'Edmonton', 'AB')
