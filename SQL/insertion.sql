/*This file fills the database with records for each table*/

-- Insert VehicleTypes
INSERT INTO VehicleType VALUES ('Small', 25, 150, 450, 25, 25);
INSERT INTO VehicleType VALUES ('Medium', 35, 210, 630, 25, 30);
INSERT INTO VehicleType VALUES ('Large', 40, 240, 720, 25, 35);

-- Insert Branches
INSERT INTO Branch VALUES ('Elmwood Street', 'Edmonton', 'AB', '780-420-6969'); --1st branch will have ID=1
INSERT INTO Branch VALUES ('Groat Road', 'Edmonton', 'AB', '780-489-0000');     --Rest will be incremented by one
INSERT INTO Branch VALUES ('Georgia St','Vancouver','BC','604-458-0450');
INSERT INTO Branch VALUES ('Marine Drive','Vancouver','BC','604-458-9997');
INSERT INTO Branch VALUES ('King St','Toronto','ON','416-458-0450');

--Insert some Users as Employees
INSERT INTO [User] VALUES ('admin', 'admin123', 'Employee', 'Male', 'Adam', 'Admin', 'Potato Road', 'Edmonton', 'AB');
INSERT INTO Employee VALUES (1, 420.69, 1);
INSERT INTO [User] VALUES ('D_shillin','123','Employee','Male','Damion','Shillinglaw','Henry ave','Edmonton','AB');
INSERT INTO Employee VALUES(2,1000,2);
INSERT INTO [User] VALUES ('FlavGuy','123','Employee','Female','Flav','Poe','Roblox st','Vancouver','BC');
INSERT INTO Employee VALUES(3,1500,3);
INSERT INTO [User] VALUES ('AlDude','123','Employee','Male','Al','Gcea','Creeper Ave','Vancouver','BC');
INSERT INTO Employee VALUES(4,2000,4);
INSERT INTO [User] VALUES ('stepBro','whatryou...','Employee','Male','Darth','Cookie','Space Ave','Toronto','ON');
INSERT INTO Employee VALUES(5,5000,5);

--Insert some Users as Customers
INSERT INTO [User] VALUES ('JazzyBird', 'bird', 'Customer', 'Female', 'Jasmine', 'Porter', 'Banana ave', 'Vancouver', 'BC');
INSERT INTO Customer VALUES (6, '145-1344', 'Regular');
INSERT INTO [User] VALUES ('spongeGuy', 'sponge', 'Customer', 'Male', 'Adam', 'Smith', 'Groat st', 'Edmonton', 'AB');
INSERT INTO Customer VALUES (7, '134-6779', 'Regular');
INSERT INTO [User] VALUES ('rgbdude', 'rgb', 'Customer', 'Male', 'Dave', 'Davey', 'Smosa ave', 'Edmonton', 'AB');
INSERT INTO Customer VALUES (8,'687-3454', 'Regular');
INSERT INTO [User] VALUES ('killerwhale', 'killer', 'Customer', 'Female', 'Seleen', 'Crocker', 'Gator ave', 'Edmonton', 'AB');
INSERT INTO Customer VALUES (9, '699-3867', 'Gold');
INSERT INTO [User] VALUES ('simpin', 'simp', 'Customer', 'Female', 'Kyla', 'Nipus', 'White ave', 'Vancouver', 'BC');
INSERT INTO Customer VALUES (10, '699-3766', 'Gold');
INSERT INTO [User] VALUES ('cherryTop', 'cherry', 'Customer', 'Female', 'Kirby', 'Sattle', 'Rosemarry ave', 'Vancouver', 'BC');
INSERT INTO Customer VALUES (11, '699-8866', 'Gold');
INSERT INTO [User] VALUES ('muffinTop', 'muffin', 'Customer', 'Male', 'Josh', 'Joshy', 'Dumpster st', 'Vancouver', 'BC');
INSERT INTO Customer VALUES (12, '699-9876', 'Regular');
INSERT INTO [User] VALUES ('brains', 'brain', 'Customer', 'Female', 'Marget', 'Thatcher', 'Gamer ave', 'Vancouver', 'BC');
INSERT INTO Customer VALUES (13, '245-1344', 'Regular');
INSERT INTO [User] VALUES ('blueJay', 'blue', 'Customer', 'Male', 'Amigo', 'Fernado', 'Spicy ave','Toronto', 'ON');
INSERT INTO Customer VALUES (14, '147-1344', 'Regular');
INSERT INTO [User] VALUES ('zombie', 'zomb', 'Customer', 'Female', 'Bob', 'Guts', 'Chicken ave', 'Toronto', 'ON');
INSERT INTO Customer VALUES (15, '145-1554', 'Regular');
INSERT INTO [User] VALUES ('turkeyNeck', 'turkey', 'Customer', 'Male', 'George', 'Gobble', 'Mayo st', 'Toronto', 'ON');
INSERT INTO Customer VALUES (16, '165-1348', 'Regular');

--Insert Vehicles 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (1000,'Honda','Civic',2021,3,'small'); 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (30000,'Mazda','Mazda3',2011,3,'small'); 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (20000,'Kia','Forte',2021,3,'small'); 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (12000,'Toyota','Corolla',2021,1,'small'); 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (1000,'Subaru','Impreza',2021,1,'small');
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (4000,'Honda','Civic',2021,5,'small');
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (1000,'Honda','Accord',2021,3,'medium');
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (70000,'Subaru','Legacy',2018,3,'medium'); 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (10530,'Subaru','Legacy',2021,4,'medium'); 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (1000,'Honda','Accord',2017,2,'medium');
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (1000,'Toyota','Camry',2021,5,'medium');
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (10000,'Ford','Expedition',2020,3,'Large');
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (70300,'Ford','Expedition',2021,4,'Large'); 
INSERT INTO Vehicle (milage,brand,model,[year],branchID,vTypeID) VALUES (9000,'Chevrolet','Suburban',2020,5,'Large');
