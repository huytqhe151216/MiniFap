Create database MiniFap
Create table Student(
	ID int identity(1,1) primary key not null,
	FistName nvarchar(255) not null,
	LastName nvarchar(255) not null,
	Email nvarchar(255) not null,
	PhoneNumber varchar(255) not null,

)