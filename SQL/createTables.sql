use [291proDatabase];

DROP TABLE IF EXISTS RentalTransaction;
DROP TABLE IF EXISTS Vehicle;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS [User];
DROP TABLE IF EXISTS Branch;
DROP TABLE IF EXISTS VehicleType;

---Create tables for car rental agency---

-- Parent table of Customer and Employee tables
CREATE TABLE [User](
	[UID] INT IDENTITY(1,1),
	userName	VARCHAR(20)	NOT NULL UNIQUE,
	passw		VARCHAR(20)	NOT NULL,	--password for userName
	userType	VARCHAR(8)	DEFAULT 'Customer',
	gender		VARCHAR(6)	NOT NULL,
	firstName	VARCHAR(15)	NOT NULL,
	lastName	VARCHAR(15)	NOT NULL,
	street		VARCHAR(30)	NOT NULL,
	city		VARCHAR(20)	NOT NULL,
	prov		VARCHAR(20)	NOT NULL,
	CONSTRAINT PKUser PRIMARY KEY([UID]),
	CONSTRAINT CheckType CHECK(userType IN ('Customer','Employee')),
	CONSTRAINT GenderCheck CHECK(gender IN ('Male','Female'))
);

--Is a child table of User table
CREATE TABLE Customer(
	customerID	INT NOT NULL,		--Is the UID from User table
	driverLic	INT	NOT NULL UNIQUE,
	membership	VARCHAR(7)	DEFAULT 'Regular',
	CONSTRAINT PKCustUser PRIMARY KEY (customerID),
	CONSTRAINT MemberCheck CHECK (membership IN ('Regular','Gold')),
	CONSTRAINT	FKCustUser	FOREIGN KEY (customerID)
	REFERENCES [User] ([UID])
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Branch(
	branchID INT IDENTITY(1,1) PRIMARY KEY,
	street	VARCHAR(30)	NOT NULL UNIQUE,
	city	VARCHAR(20)	NOT NULL,
	prov	VARCHAR(20)	NOT NULL,
	phoneNumber VARCHAR(20) NOT NULL UNIQUE
);

--Is a child table of User table
CREATE TABLE Employee(
	employID INT NOT NULL,		--Is the user ID from User table
	salary		FLOAT	NULL,
	branchID INT NOT NULL,
	CONSTRAINT FKWorkAtBranch FOREIGN KEY (branchID)
	REFERENCES Branch(branchID), 
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
	changeCharge FLOAT NOT NULL,
	CONSTRAINT PkSizes CHECK (vTypeID IN ('Small','Medium','Large'))
);

CREATE TABLE Vehicle(
	vehicleID	INT IDENTITY(1,1) PRIMARY KEY,
	milage	INT	NOT NULL,
	brand	VARCHAR(15) NOT NULL,
	model	VARCHAR(15) NOT NULL,
	[year]	INT	NOT NULL,
	branchID INT NOT NULL,
	vTypeID VARCHAR(10) NOT NULL,
	CONSTRAINT FKOwnByBranch FOREIGN KEY (branchID) 
	REFERENCES Branch(branchID),
	CONSTRAINT FKBelongVType FOREIGN KEY (vTypeID)
	REFERENCES VehicleType(vTypeID)
);

CREATE TABLE RentalTransaction(
	rentalID	INT	IDENTITY(1,1) PRIMARY KEY,
	userID		INT NOT NULL,
	dateBooked	DATETIME NOT NULL DEFAULT (GETDATE()),
	expRetDate	DATETIME NOT NULL,
	actRetDate	DATETIME NULL,
	empBorrow INT NOT NULL,    --Employee who processes borrow transaction
	empRet INT FOREIGN KEY REFERENCES Employee(employID),		--Employee who processes return transaction
	branchBorrow INT NOT NULL, 
	eBranchReturn INT FOREIGN KEY REFERENCES Branch(branchID), --The expected branch of return 
	aBranchReturn INT FOREIGN KEY REFERENCES Branch(branchID), --Actual branch of return
	rentedVID INT FOREIGN KEY REFERENCES Vehicle(vehicleID),
	vTypeID VARCHAR(10) NOT NULL,   --Customer's requested vehicle type
	CONSTRAINT FKReqVType FOREIGN KEY (vTypeID)
	REFERENCES VehicleType(vTypeID),   
	CONSTRAINT FKEmpBorrow FOREIGN KEY (empBorrow)
	REFERENCES Employee(employID),
	CONSTRAINT FKBranBorrow FOREIGN KEY (branchBorrow) 
	REFERENCES Branch(branchID),
	CONSTRAINT FKUserID FOREIGN KEY (userID)
	REFERENCES [User]([UID])
);

-- Some lines to create some branches and the vehicleTypes

-- VehicleTypes
INSERT INTO VehicleType VALUES ('Small', 25, 150, 450, 25, 25);
INSERT INTO VehicleType VALUES ('Medium', 35, 210, 630, 25, 30);
INSERT INTO VehicleType VALUES ('Large', 40, 240, 720, 25, 35);
-- Branches
INSERT INTO Branch VALUES ('Elmwood Street', 'Edmonton', 'AB', '7804206969');
INSERT INTO Branch VALUES ('Something Street', 'Edmonton', 'AB', '7804890000');

