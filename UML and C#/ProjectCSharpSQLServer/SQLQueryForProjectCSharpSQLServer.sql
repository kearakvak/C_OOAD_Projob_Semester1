CREATE TABLE tbStaff(
	StaffID smallint Primary Key,
	StaffNameKH nvarchar(35) Collate SQL_Latin1_General_CP850_Bin,
	StaffNameEN varchar(25) Not NULL,
	Gender varchar(6) Not NULL,
	BirthDate date Not NULL,
	Phone varchar(20) NULL,
	StaffAddress varchar(250) Not NULL,
	StaffPosition varchar(150) Not NULL,
	Salary money Not NULL,
	HiredDate date Not NULL,
	StopWork bit Not NULL,
	Photo varbinary(Max) NULL
)
Go
Create Procedure spRunSQL @sql nText As
Begin
	Exec(@sql)
End
Go
CREATE Procedure spInsertStaff 
	@id smallint, @snKH nvarchar(35),
	@snEN varchar(25), @g varchar(6), 
	@bd date, @ph varchar(20), 
	@ad varchar(250), @pos varchar(150), 
	@sal money, @hd date, 
	@sw bit, @img varbinary(MAX) As
Begin
	INSERT INTO tbStaff(StaffID, StaffNameKH, StaffNameEN, Gender, 
		BirthDate, Phone, StaffAddress, StaffPosition, Salary, 
		HiredDate, StopWork, Photo) 
	VALUES(@id, @snKH, @snEN, @g, @bd, @ph, @ad, @pos, @sal,
		@hd, @sw, @img)
End
Go
CREATE Procedure spEditStaff 
	@id smallint, @snKH nvarchar(35),
	@snEN varchar(25), @g varchar(6), 
	@bd date, @ph varchar(20), 
	@ad varchar(250), @pos varchar(150), 
	@sal money, @hd date, 
	@sw bit, @img varbinary(MAX) As
Begin
	UPDATE tbStaff SET StaffNameKH = @snKH, StaffNameEN = @snEN, 
		Gender = @g, BirthDate = @bd, Phone = @ph, 
		StaffAddress = @ad, StaffPosition = @pos, 
		Salary = @sal, HiredDate = @hd, StopWork = @sw,
		Photo = @img 
	WHERE StaffID = @id 
End

