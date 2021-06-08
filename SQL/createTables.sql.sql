use [291proDatabase];
drop table RentalTransaction;
drop table Vehicle;
drop table Employee;
drop table Customer;
drop table Branch;
drop table VehicleType;

---Create tables for car rental agency---
CREATE TABLE Customer(
	customerID	INT	IDENTITY(1,1) PRIMARY KEY,
	firstName	CHAR(15)	NOT NULL,
	lastName	CHAR(20)	NOT NULL,
	street		CHAR(30)	NULL,
	city		CHAR(20)	NULL,
	prov		CHAR(20)	NULL,
	driverLic	INT			NOT NULL,
	membership	CHAR(7)	DEFAULT 'Regular',
	gender		CHAR(5)		NOT NULL
);

CREATE TABLE Branch(
	branchID INT IDENTITY(1,1) PRIMARY KEY,
	street	CHAR(30)	NOT NULL,
	city	CHAR(20)	NOT NULL,
	prov	CHAR(20)	NOT NULL,
	phoneNumber CHAR(20) NOT NULL
);

CREATE TABLE Employee(
	employID INT IDENTITY(1,1) PRIMARY KEY,
	firstName	CHAR(15)	NOT NULL,
	lastName	CHAR(20)	NOT NULL,
	salary		FLOAT		NOT NULL,
	gender		CHAR(7)		NOT NULL,
	branchID INT FOREIGN KEY REFERENCES Branch(branchID)
);

CREATE TABLE VehicleType(
	vehTypeID	VARCHAR(10) PRIMARY KEY,
	dRate	FLOAT	NOT NULL,
	wRate	FLOAT	NOT NULL,
	mRate	FLOAT	NOT NULL,
	lateFee	FLOAT	NOT NULL,
	changeCharge FLOAT NOT NULL
);

CREATE TABLE Vehicle(
	vehicleID	INT IDENTITY(1,1) PRIMARY KEY,
	--size	CHAR(7)	NOT NULL,
	milage	INT	NOT NULL,
	brand	CHAR(15) NOT NULL,
	model	CHAR(15) NOT NULL,
	[year]	INT	NOT NULL,
	branchID INT FOREIGN KEY REFERENCES Branch(branchID),
	vehTypeID VARCHAR(10) FOREIGN KEY REFERENCES VehicleType(vehTypeID)
);

CREATE TABLE RentalTransaction(
	rentalID	INT	IDENTITY(1,1) PRIMARY KEY,
	dateBooked	DATETIME,
	expRetDate	DATETIME NOT NULL,
	actRetDate	DATETIME NULL,
	customerID INT FOREIGN KEY REFERENCES Customer(customerID),
	empBorrow INT FOREIGN KEY REFERENCES Employee(employID),
	empRet INT FOREIGN KEY REFERENCES Employee(employID),
	branchBorrow INT FOREIGN KEY REFERENCES Branch(branchID),
	branchReturn INT FOREIGN KEY REFERENCES Branch(branchID),
	rentedVehID INT FOREIGN KEY REFERENCES Vehicle(vehicleID),
	vehTypeID VARCHAR(10) FOREIGN KEY REFERENCES	VehicleType(vehTypeID)
);


