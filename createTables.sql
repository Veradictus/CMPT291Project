/*CMPT 291 Project, OP01, Spring Term 2021
Group Members: Damion Shillinglaw, Kelly Flores, Gerardo Cea, Flavius Poenaru
*/

use [291proDatabase];

DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Branch;
DROP TABLE IF EXISTS Vehicle;
DROP TABLE IF EXISTS RentalTransaction;
DROP TABLE IF EXISTS VehicleType;
DROP TABLE IF EXISTS [User];

---Create tables for car rental agency---
CREATE TABLE [User](
	[UID] INT IDENTITY(1,1),
	userName	CHAR(20)	NOT NULL,
	passw		CHAR(20)	NOT NULL,
	userType	CHAR(8)		DEFAULT 'customer',
	gender		CHAR(5)		NOT NULL,
	firstName	CHAR(15)	NOT NULL,
	lastName	CHAR(15)	NOT NULL,
	street		CHAR(30)	NOT NULL,
	city		CHAR(20)	NOT NULL,
	prov		CHAR(20)	NOT NULL,
	CONSTRAINT PKUser PRIMARY KEY ([UID])
);

CREATE TABLE Customer(
	customerID	INT,		--Is the UID from User table
	driverLic	INT			NOT NULL,
	membership	CHAR(7)	DEFAULT 'Regular',
	CONSTRAINT PKCustUser PRIMARY KEY (customerID),
	CONSTRAINT	FKCustUser	FOREIGN KEY (customerID)
	REFERENCES [User] ([UID])
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Branch(
	branchID INT IDENTITY(1,1) PRIMARY KEY,
	street	CHAR(30)	NOT NULL,
	city	CHAR(20)	NOT NULL,
	prov	CHAR(20)	NOT NULL,
	phoneNumber CHAR(20) NOT NULL
);

CREATE TABLE Employee(
	employID INT,		--Is the user ID from User table
	salary		FLOAT		NOT NULL,
	branchID INT FOREIGN KEY REFERENCES Branch(branchID) NOT NULL,
	CONSTRAINT	PKEmpUser	PRIMARY KEY (employID),	
	CONSTRAINT FKEmpUser FOREIGN KEY (employID)
	REFERENCES [User]([UID])
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE VehicleType(
	vTypeID VARCHAR(10) PRIMARY KEY, --Will represent sizes: small,medium,large
	dRate	FLOAT	NOT NULL,
	wRate	FLOAT	NOT NULL,
	mRate	FLOAT	NOT NULL,
	lateFee	FLOAT	NOT NULL,
	changeCharge FLOAT NOT NULL
);

CREATE TABLE Vehicle(
	vehicleID	INT IDENTITY(1,1) PRIMARY KEY,
	milage	INT	NOT NULL,
	brand	CHAR(15) NOT NULL,
	model	CHAR(15) NOT NULL,
	[year]	INT	NOT NULL,
	branchID INT FOREIGN KEY REFERENCES Branch(branchID),
	vTypeID VARCHAR(10) FOREIGN KEY REFERENCES VehicleType(vTypeID)
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
	rentedVID INT FOREIGN KEY REFERENCES Vehicle(vehicleID),
	vTypeID VARCHAR(10) FOREIGN KEY REFERENCES	VehicleType(vTypeID)
);

