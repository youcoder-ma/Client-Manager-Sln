CREATE DATABASE CLIENT;
USE CLIENT;

Create Table Clients(
	ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	FName nvarchar(250) NOT NULL Unique,
	LName nvarchar(250) NOT NULL,
	Adress nvarchar(250) NOT NULL,
	City nvarchar(250) NOT NULL,
	);

Insert into Clients values ('Mouad', 'Rmaili', '12 street', 'Youssoufia');
Insert into Clients values ('Adil', 'fadili', '13 street', 'Casablanca');
Insert into Clients values ('Marouane', 'Rochdi', '15 street', 'Rabat');

Delete from Clients where ID = 1



select * from Clients;
delete from Clients;
drop table Clients;