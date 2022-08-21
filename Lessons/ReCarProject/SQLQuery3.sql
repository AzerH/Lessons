﻿create table Cars (CarId int primary key not null identity (1,1),CarName nvarchar(30), BrandId int, ColorId int, ModelYear int, DailyPrice decimal, Description nvarchar(300))
create table Brands (BrandId int primary key identity (1,1) not null, BrandName nvarchar(20))
create table Colors(ColorId int primary key identity (1,1) not null, ColorName nvarchar(20))
create table Users (UserId int primary key identity (1,1) not null, Firstname Nvarchar(20), Lastame nvarchar(20), Email nvarchar(30) not null, Password nvarchar(30))
create table Customers(CustomerId int primary key  identity (1,1) not null, UserId int not null, CompanyName nvarchar(30) not null)
create table Rentals (RentId int primary key  identity (1,1) not null, CarId int not null,CustomerId int not null, RentDate DateTime not null, ReturnDate DateTime)