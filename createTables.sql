use [291proDatabase];

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

CREATE TABLE Vehicle(
	vehicleID	INT IDENTITY(1,1) PRIMARY KEY,
	size	CHAR(7)	NOT NULL,
	milage	INT	NOT NULL,
	brand	CHAR(15) NOT NULL,
	model	CHAR(15) NOT NULL,
	[year]	INT	NOT NULL,
	branchID INT FOREIGN KEY REFERENCES Branch(branchID)
);

CREATE TABLE RentalTransaction(
	rentalID	INT	IDENTITY(1,1) PRIMARY KEY,
	dateBooked	DATETIME,
	expRetDate	DATETIME NOT NULL,
	actRetDate	DATETIME NULL,
	empBorrow INT FOREIGN KEY REFERENCES Employee(employID),
	empRet INT FOREIGN KEY REFERENCES Employee(employID),
	branchBorrow INT FOREIGN KEY REFERENCES Branch(branchID),
	branchReturn INT FOREIGN KEY REFERENCES Branch(branchID),
	rentedVehID INT FOREIGN KEY REFERENCES Vehicle(vehicleID),
	reqVehID INT FOREIGN KEY REFERENCES	Vehicle(vehicleID)
);

CREATE TABLE VehicleType(
	vehID	INT IDENTITY(1,1) PRIMARY KEY,
	vehTypeID INT NOT NULL REFERENCES Vehicle(vehicleID),
	dRate	FLOAT	NOT NULL,
	wRate	FLOAT	NOT NULL,
	mRate	FLOAT	NOT NULL,
	lateFee	FLOAT	NOT NULL,
	changeCharge FLOAT NOT NULL
);

