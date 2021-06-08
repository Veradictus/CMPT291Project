USE prj291;

--- Non foreign key related tables ---
CREATE TABLE Agency ( agencyID INT PRIMARY KEY );
CREATE TABLE VehicleEntry ( vEntryID INT PRIMARY KEY );
CREATE TABLE Customer ( 
    customerID int NOT NULL PRIMARY KEY,
    name varchar(32) NOT NULL,
    address varchar(32),
    membership varchar(4));

--- Tables containnig foreign keys ---
CREATE TABLE Branch (
    branchID int NOT NULL PRIMARY KEY, 
    agencyID int FOREIGN KEY REFERENCES Agency(agencyID));

CREATE TABLE Employee (
    employeeID int NOT NULL PRIMARY KEY,
    name varchar(32),
    salary int,
    branchID int FOREIGN KEY REFERENCES Branch(branchID),
    agencyID int FOREIGN KEY REFERENCES Agency(agencyID)
);

CREATE TABLE Vehicle (
    vehicleID int NOT NULL PRIMARY KEY,
    type varchar(16),
    size varchar(16),
    customerID int FOREIGN KEY REFERENCES Customer(customerID),
    branchID int FOREIGN KEY REFERENCES Branch(branchID),
    agencyID int FOREIGN KEY REFERENCES Agency(agencyID)
);