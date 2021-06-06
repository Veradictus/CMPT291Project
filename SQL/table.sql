USE prj291;

--- Non foreign key related tables ---
CREATE TABLE IF NOT EXISTS Agency ( agencyID INT PRIMARY KEY );
CREATE TABLE IF NOT EXISTS VehicleEntry ( vEntryID INT PRIMARY KEY );
CREATE TABLE IF NOT EXISTS Customer ( 
    customerID INT PRIMARY KEY,
    name varchar(32),
    address varchar(32),
    membership varchar(4));

--- Tables containnig foreign keys ---
CREATE TABLE IF NOT EXISTS Branch (
    branchID INT PRIMARY KEY, 
    FOREIGN KEY (agencyID) REFERENCES Agency(agencyID));

CREATE TABLE IF NOT EXISTS Employee (
    employeeID INT PRIMARY KEY,
    name varchar(32),
    salary int,
    FOREIGN KEY branchID REFERENCES Branch(branchID),
    FOREIGN KEY agencyID REFERENCES Agency(agencyID)
);

CREATE TABLE IF NOT EXISTS Vehicle (
    vehicleID INT PRIMARY KEY,
    type varchar(16),
    size varchar(16),
    FOREIGN KEY customerID REFERENCES Customer(customerID),
    FOREIGN KEY branchID REFERENCES Branch(branchID),
    FOREIGN KEY agencyID REFERENCES Agency(agencyID)
);