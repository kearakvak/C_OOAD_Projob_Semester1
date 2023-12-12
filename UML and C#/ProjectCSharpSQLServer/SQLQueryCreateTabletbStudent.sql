Create Table tbStudent (
	StudentID int Primary Key Identity(1,1),
	StuNameKH nvarchar(35) Collate SQL_Latin1_General_CP850_Bin,
	StuNameEN varchar(25),
	Gender varchar(6),
	BirthDate date,
	StuPhone varchar(20),
	ParentPhone varchar(20),
	PersonalAddress varchar(250),
	ContactAddress varchar(250)
)
Go
Insert Into tbStudent (StuNameKH, StuNameEN, Gender, BirthDate, 
	StuPhone, ParentPhone, PersonalAddress, ContactAddress)
Values	(N'ចាន់ ម៉ាលី', 'Chan Maly', 'Female', '2005-01-15', 
		'(085) 384-384', '(012) 387-384', 'Phnom Penh', 'Phnom Penh'),
		(N'គឹម តារា', 'Kim Dara', 'Male', '2005-11-25', 
		'(085) 432-123', '(012) 432-123', 'Phnom Penh', 'Kandal')