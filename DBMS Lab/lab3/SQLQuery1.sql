create database Sales;

create table tblShippers(
ShipperId varchar(10) PRIMARY KEY,
CompanyName varchar(10),
);

Insert into tblShippers values(1,'GoLootlo');
Insert into tblShippers values(2,'Daraz');
Insert into tblShippers values(1,'Palvene');

create table tblCustomers(
CustomerId varchar(10) PRIMARY KEY ,
CompanyName varchar(50),
ContactName varchar(50),
ContactTitle varchar(50),
Address varchar(250),
City varchar(50),
Region varchar(50),
PostalCode int,
Country varchar(50),
Phone varchar(50),
Fax varchar(50),
);

Insert into tblCustomers values (1,'YOungstr','Salman','Nill','New Samanabad ','Lahore','Samanabad',54500,'Pakistan','03078809765','FX100001');
Insert into tblCustomers values (2,'SHubhan','Shubhan','Nill','New Qianchi','Lahore','Qainchi',54000,'Pakistan','03070000001','FX100002');
Insert into tblCustomers values (1,'Kolson','Aslam','Nill','New Thokar Niaz','Lahore','Thokar',56500,'Pakistan','03070000002','FX100003');

create table tblOrders(
OrderID varchar(10) PRIMARY KEY,
CustomerID varchar(10) references tblCustomers,
EmployeeID varchar(10),
ShipName varchar(50),
ShipAddress varchar(250),
ShipCity varchar(50),
ShipRegion varchar(50),
ShipPostalCode varchar(10),
ShipCountry varchar(50),
ShipID varchar(10) references tblShippers,
OrderDate datetime,
RequiredDate datetime,
ShippedDate datetime,
Freight varchar(50)
)






create table tblSupplier(
SupplierID varchar(10) PRIMARY KEY,
Name varchar(50),
Address varchar(250),
City varchar(50),
Province varchar(50),
)

create table tblProducts(
ProductID varchar(10) PRIMARY KEY ,
SupplierID varchar(10) references tblSupplier,
CategoryID varchar(10),
ProductName varchar(50),
EnglishName varchar(50),
QuantityPerUnit int,
UnitPrice float,
UnitsInStock int,
UnitsOnOrder int,
ReorderLevel int,
Discontinued bit,
)
create table tblOrderDetails(
OrderID varchar(10) references tblOrders,
ProductID varchar(10) references tblProducts,
UnitPrice money,
Qunatity int,
Discount float,
)

Alter table tblProducts ADD CONSTRAINT check_Qunatity_Per_Unit CHECK (QuantityPerUnit BETWEEN 1 and 10) 

Insert into tblProducts values (1,1,'Food','Cocomo','Cocomo',3,10,5,2,2,0.10,3);
Insert into tblProducts values (2,1,'Food','Biscuito','Biscuito',3,10,5,2,2,0.10,3);
Insert into tblProducts values (3,2,'Clothes','Denimin JEans','Denimin Jeans',3,10,5,2,2,0.10,3);

Insert into tblSupplier values (1,'Kolson','New Mirza Anwar Stop','Lahore','Punjab');
Insert into tblSupplier values (2,'Levis','New Samanabad Anwar Stop','Lahore','Punjab');
Insert into tblSupplier values (3,'Bisconi','New Gulshan e Ravi Anwar Stop','Lahore','Punjab');

