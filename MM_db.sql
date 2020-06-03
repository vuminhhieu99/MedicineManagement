CREATE DATABASE QuanLyThuoc
GO

USE QuanLyThuoc
GO

CREATE TABLE INPUTCOUPON(
	ID_InputCoupon int IDENTITY(1,1) NOT NULL,
	CreateDate date NULL,
	ID_Supplier int NULL,
	TotalMoney decimal(12, 0) NULL,
 CONSTRAINT  PK_PHIEUNHAP  PRIMARY KEY (ID_InputCoupon)
 )
 GO

 CREATE TABLE INPUTCOUPONLINE (
	 ID_InputCouponLine int  IDENTITY(1,1) NOT NULL,
	 ID_InputCoupon int  NULL,
	 ID_Medicine int  NULL,
	 Name nvarchar (100) NULL,
	 UnitInput nvarchar (50) NULL,
	 Amount int  NULL,
	 Price decimal (10, 0) NULL,
	 ExpiryDate date  NULL,
	 NumUnitOutput int  NULL,
	 ProductionBatch NCHAR (10) NULL,
	 IntoMoney decimal (12, 0) NULL,
 CONSTRAINT  PK_DONGPHIEUNHAP  PRIMARY KEY ( ID_InputCouponLine  )
 )
GO

 CREATE TABLE  MEDICINE (
	 ID_Medicine int  IDENTITY(1,1) NOT NULL,
	 Name nvarchar (100) NULL,
	 MedicineGroup nvarchar (100) NULL,
	 Uses nvarchar (max) NULL,
	 Unit nvarchar (50) NULL,
	 Price decimal (10, 0) NULL,
	 TotalInventory INT NULL,
	 Note nvarchar (max) NULL,
	 MostUsedMonth int  NULL,
 CONSTRAINT  PK_THUOC  PRIMARY KEY ( ID_Medicine  ) 
 )
GO

CREATE TABLE PRESCRIPTION (
	 ID_Prescription int  IDENTITY(1,1) NOT NULL,
	 CreateDate date  NULL,
	 Doctor nvarchar (100) NULL,
	 MedicalRecord int  NULL,
	 Drugstores int  NULL,
	 TotalMoney decimal (10, 0) NULL,
 CONSTRAINT  PK_DONTHUOC  PRIMARY KEY ( ID_Prescription  ) 
 )
GO

CREATE TABLE PRESCRIPTIONLINE (
	 ID_Prescription int  NOT NULL,
	 ID_Medicine int NOT NULL,
	 Amount int  NULL,
	 HealthInsurance decimal (10, 0) NULL,
	 IntoMoney decimal (10, 0) NULL,
 CONSTRAINT  PK_DONGDONTHUOC  PRIMARY KEY (	 ID_Prescription  ,	 ID_Medicine )
 )
GO

CREATE TABLE SUPPLIER (
	 ID_Supplier int  IDENTITY(1,1) NOT NULL,
	 Name nvarchar (max) NULL,
	 Address nvarchar (max) NULL,
	 Phone varchar (20) NULL,
	 Email varchar (100) NULL,
 CONSTRAINT  PK_NHACUNGCAP  PRIMARY KEY (	 ID_Supplier )
 )
GO

-- UserInfo
CREATE TABLE USERINFO
(
	UserName NVARCHAR(200),
	UserAddress NVARCHAR(400),
	UserEmail VARCHAR(200),
	UserPhone VARCHAR(15),
	CreateDate DATE,
)
--

insert into USERINFO Values (N'hahaha',N'bbbbb','emial@mgaisa.com','0132643216432','2019-10-10')

ALTER TABLE [dbo].[INPUTCOUPON] ADD  CONSTRAINT [DF_PHIEUNHAP_TongTien]  DEFAULT ((0)) FOR [TotalMoney]
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE] ADD  CONSTRAINT [DF_DONGPHIEUNHAP_SoLuong]  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE] ADD  CONSTRAINT [DF_DONGPHIEUNHAP_Gia]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE] ADD  CONSTRAINT [DF_DONGPHIEUNHAP_TileSoLuong]  DEFAULT ((0)) FOR [NumUnitOutput]
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE] ADD  CONSTRAINT [DF_DONGPHIEUNHAP_ThanhTien]  DEFAULT ((0)) FOR [IntoMoney]
GO
ALTER TABLE [dbo].[MEDICINE] ADD  CONSTRAINT [DF_THUOC_Gia]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[MEDICINE] ADD  CONSTRAINT [DF_THUOC_TonKho]  DEFAULT ((0)) FOR [TotalInventory]
GO
ALTER TABLE [dbo].[PRESCRIPTION] ADD  CONSTRAINT [DF_DONTHUOC_ThanhTien]  DEFAULT ((0)) FOR [TotalMoney]
GO
ALTER TABLE [dbo].[PRESCRIPTIONLINE] ADD  CONSTRAINT [DF_DONGDONTHUOC_SoLuong]  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[PRESCRIPTIONLINE] ADD  CONSTRAINT [DF_DONGDONTHUOC_BHYT]  DEFAULT ((0)) FOR [HealthInsurance]
GO
ALTER TABLE [dbo].[PRESCRIPTIONLINE] ADD  CONSTRAINT [DF_DONGDONTHUOC_ThanhTien]  DEFAULT ((0)) FOR [IntoMoney]
GO

ALTER TABLE [dbo].[INPUTCOUPON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[SUPPLIER] ([ID_Supplier])
GO
ALTER TABLE [dbo].[INPUTCOUPON] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE]  WITH CHECK ADD  CONSTRAINT [FK_DONGPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([ID_InputCoupon])
REFERENCES [dbo].[INPUTCOUPON] ([ID_InputCoupon])
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE] CHECK CONSTRAINT [FK_DONGPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE]  WITH CHECK ADD  CONSTRAINT [FK_DONGPHIEUNHAP_THUOC] FOREIGN KEY([ID_Medicine])
REFERENCES [dbo].[MEDICINE] ([ID_Medicine])
GO
ALTER TABLE [dbo].[INPUTCOUPONLINE] CHECK CONSTRAINT [FK_DONGPHIEUNHAP_THUOC]
GO
ALTER TABLE [dbo].[PRESCRIPTIONLINE]  WITH CHECK ADD  CONSTRAINT [FK_DONGDONTHUOC_DONTHUOC] FOREIGN KEY([ID_Prescription])
REFERENCES [dbo].[PRESCRIPTION] ([ID_Prescription])
GO
ALTER TABLE [dbo].[PRESCRIPTIONLINE] CHECK CONSTRAINT [FK_DONGDONTHUOC_DONTHUOC]
GO
ALTER TABLE [dbo].[PRESCRIPTIONLINE]  WITH CHECK ADD  CONSTRAINT [FK_PRESCRIPTIONLINE_MEDICINE] FOREIGN KEY([ID_Medicine])
REFERENCES [dbo].[MEDICINE] ([ID_Medicine])
GO
ALTER TABLE [dbo].[PRESCRIPTIONLINE] CHECK CONSTRAINT [FK_PRESCRIPTIONLINE_MEDICINE]
GO

----------------
-- PROCEDUCES --
----------------
CREATE PROC InsertSUPPLIER(@Name NVARCHAR(MAX), @Address NVARCHAR(MAX), @Phone VARCHAR(20), @Email VARBINARY(MAX))
AS
BEGIN
	INSERT DBO.SUPPLIER([Name] , [Address] , [Phone] , [Email]) VALUES ( @Name, @Address, @Phone, @Email)

END
GO

CREATE PROC InsertINPUTCOUPON(@CreateDate DATE, @ID_Supplier INT, @TotalMoney DECIMAL(12,0))
AS
BEGIN
	INSERT DBO.INPUTCOUPON( [CreateDate], [ID_Supplier], [TotalMoney]) VALUES  (@CreateDate, @ID_Supplier , @TotalMoney)
END
GO

CREATE PROC InsertMEDICINE(@Name NVARCHAR(100), @MedicineGroup NVARCHAR(100),@Uses NVARCHAR(MAX), @Unit NVARCHAR(50), @Price DECIMAL(10,0), @TotalInventory INT, @Note NVARCHAR(MAX), @MostUsedMonth INT )
AS
BEGIN
	INSERT DBO.MEDICINE( [Name], [MedicineGroup],[Uses] , [Unit], [Price],[TotalInventory], [Note], [MostUsedMonth]) VALUES  (@Name, @MedicineGroup, @Uses, @Unit, @Price, @TotalInventory,@Note, @MostUsedMonth)
END
GO

CREATE PROC InsertPRESCRIPTION(@CreateDate DATE, @Doctor NVARCHAR(100), @MedicalRecord INT, @Drugstores INT, @TotalMoney DECIMAL(10,0))
AS
BEGIN
	INSERT DBO.PRESCRIPTION([CreateDate], [Doctor], [MedicalRecord], [Drugstores] , [TotalMoney]) VALUES  (@CreateDate, @Doctor, @MedicalRecord, @Drugstores, @TotalMoney)
END
GO

-- Insert INPUTCOUPONLINE
CREATE PROC InsertINPUTCOUPONLINE ( @ID_inputCoupon INT, @ID_medicine INT, @name NVARCHAR(100), @unitInput NVARCHAR(50), @amount INT, @price DECIMAL(10,0), @expiryDate DATE, @NumUnitOutput INT , @productionBatch NCHAR(10) )
AS
BEGIN
	DECLARE @intoMoney DECIMAL(12,0)
	SET @intoMoney = @price * @amount
	DECLARE @totalNumUnitOutput DECIMAL 
	SET @totalNumUnitOutput = @numUnitOutput * @amount
	

	INSERT INTO dbo.INPUTCOUPONLINE ( [ID_InputCoupon], [ID_Medicine] ,[Name] ,[UnitInput] ,[Amount] ,[Price] ,[ExpiryDate] ,[NumUnitOutput] ,[ProductionBatch] ,[IntoMoney] )
	VALUES  ( @ID_inputCoupon, @ID_medicine, @name, @unitInput, @amount, @price, @expiryDate, @NumUnitOutput, @productionBatch, @intoMoney )

	UPDATE dbo.INPUTCOUPON SET TotalMoney = TotalMoney + @intoMoney
	WHERE ID_InputCoupon = @ID_inputCoupon
	
	UPDATE dbo.MEDICINE SET TotalInventory = TotalInventory + @totalNumUnitOutput
	WHERE ID_Medicine = @ID_medicine
END
GO

-- Delete INPUTCOUPONLINE
CREATE TRIGGER DeleteINPUTCOUPONLINE ON INPUTCOUPONLINE
FOR DELETE
AS
BEGIN
	DECLARE @intoMoney DECIMAL(12,0)
	DECLARE @numUnitOutput INT
	DECLARE @amount INT
	DECLARE @ID_inputCoupon INT
	DECLARE @ID_Medicine INT

	DECLARE @totalNumUnitOutput INT

	SELECT
		@intoMoney = IntoMoney,
		@numUnitOutput = NumUnitOutput	,
		@amount = Amount,
		@ID_inputCoupon = ID_inputCoupon,
		@ID_Medicine = ID_Medicine 
	FROM dbo.INPUTCOUPONLINE
	WHERE ID_InputCouponLine IN	( SELECT deleted.ID_InputCouponLine  FROM  deleted)

	SET @totalNumUnitOutput = @numUnitOutput * @amount
	 
		
	UPDATE dbo.INPUTCOUPON 
	SET TotalMoney = TotalMoney - @intoMoney
	WHERE ID_InputCoupon = @ID_inputCoupon

	UPDATE dbo.MEDICINE SET TotalInventory = TotalInventory - @totalNumUnitOutput
	WHERE ID_Medicine = @ID_medicine
END
GO
-- Insert PRESCRIPTIONLINE
CREATE PROC InsertPRESCRIPTIONLINE ( @ID_prescription INT, @ID_medicine INT, @amount INT, @healthInsurance DECIMAL(10,0) )
AS
BEGIN
	DECLARE @price DECIMAL
	DECLARE @intoMoney DECIMAL(10,0)

	SELECT @price = Price FROM dbo.MEDICINE WHERE ID_Medicine = @ID_medicine
	SET @intoMoney = @price * @amount - @healthInsurance

	INSERT INTO dbo.PRESCRIPTIONLINE( ID_Prescription, ID_Medicine, Amount, HealthInsurance, IntoMoney )
	VALUES  ( @ID_prescription, @ID_medicine, @amount, @healthInsurance, @intoMoney )
	
	UPDATE dbo.MEDICINE
	SET TotalInventory = TotalInventory - @amount
	WHERE ID_Medicine =  @ID_medicine

	UPDATE dbo.PRESCRIPTION
	SET TotalMoney = TotalMoney + @intoMoney
	WHERE ID_Prescription = @ID_prescription
END
GO

-- Delete PRESCRIPTIONLINE
CREATE TRIGGER DeletePRESCRIPTIONLINE ON PRESCRIPTIONLINE
FOR DELETE
AS
BEGIN
	DECLARE @intoMoney DECIMAL(10,0)
	DECLARE @ID_prescription INT
	DECLARE @ID_medicine INT

	SELECT @ID_prescription = ID_prescription, @ID_medicine = ID_medicine FROM deleted

	SELECT @intoMoney = IntoMoney FROM dbo.PRESCRIPTIONLINE
	WHERE ID_Prescription = @ID_prescription AND ID_Medicine = @ID_medicine

	DECLARE @amount DECIMAL
	SELECT @amount = Amount FROM dbo.PRESCRIPTIONLINE
	WHERE ID_Prescription = @ID_prescription AND ID_Medicine = @ID_medicine
	
	UPDATE dbo.PRESCRIPTION
	SET TotalMoney = TotalMoney - @intoMoney 
	WHERE ID_Prescription = @ID_prescription

	UPDATE dbo.MEDICINE
	SET TotalInventory = TotalInventory + @amount
	WHERE ID_Medicine =  @ID_medicine

	DELETE FROM dbo.PRESCRIPTIONLINE
	WHERE ID_Prescription = @ID_prescription AND ID_Medicine = @ID_medicine
END
GO


-- Update INPUTCOUPON
CREATE PROC UpdateINPUTCOUPON (@ID_InputCoupon INT, @CreateDate DATE, @TotalMoney DECIMAL(12,0), @ID_Supplier INT)
AS
BEGIN
	UPDATE dbo.INPUTCOUPON SET [CreateDate] = @CreateDate, [TotalMoney] = @TotalMoney, [ID_Supplier] =@ID_Supplier
	WHERE ID_InputCoupon = @ID_InputCoupon
END
GO
-- Update PRESCRIPTION
CREATE PROC UpdatePRESCRIPTION (@ID_Prescription INT, @CreateDate DATE, @Doctor NVARCHAR(100), @MedicalRecord INT, @Drugstores INT, @TotalMoney DECIMAL(10,0))
AS
BEGIN
	UPDATE dbo.PRESCRIPTION SET [CreateDate] = @CreateDate, [Doctor] =@Doctor, [MedicalRecord] = @MedicalRecord, [TotalMoney]= @TotalMoney
	WHERE [ID_Prescription] = @ID_Prescription
END
GO

-- Update SUPPLIER
CREATE PROC UpdateSUPPLIER(@ID_Supplier INT, @Name NVARCHAR(MAX), @Address NVARCHAR(MAX), @Phone VARCHAR(20), @Email VARCHAR(100))
AS
BEGIN
	UPDATE dbo.SUPPLIER SET [Name] = @Name, [Address] =@Address, [Phone] = @Phone, [Email]= @Email
	WHERE [ID_Supplier] = @ID_Supplier
END
GO


CREATE PROC UpdateMEDICINE (@ID_Medicine INT, @Name NVARCHAR(100), @MedicineGroup NVARCHAR(100), @Uses NVARCHAR(MAX), @Unit NVARCHAR(50), @Price DECIMAL(10,0), @TotalInventory INT, @Note NVARCHAR(MAX), @MostUsedMonth INT)
AS
BEGIN
	UPDATE dbo.MEDICINE SET [Name] = @Name, [MedicineGroup] = @MedicineGroup, [Uses] =@Uses, [Unit] = @Unit, [Price] = @Price, [TotalInventory] = @TotalInventory, [Note] = @Note, [MostUsedMonth] = @MostUsedMonth
	WHERE [ID_Medicine] = @ID_Medicine
END
GO
------------------


-- Update INPUTCOUPONLINE
ALTER PROC UpdateINPUTCOUPONLINE (@ID_InputCouponLine INT, @ID_inputCoupon INT, @ID_medicine INT, @name NVARCHAR(100), @unitInput NVARCHAR(50), @amount INT, @price DECIMAL(10,0), @expiryDate DATE, @NumUnitOutput INT, @productionBatch NCHAR(10))
AS
BEGIN
	DECLARE @totalNumUnitOutput INT	
	 
	DECLARE @OLD_intoMoney DECIMAL(12,0)  -- tổng tiền cũ
	DECLARE @OLD_numUnitOutput INT   -- đơn vị cũ
	DECLARE @OLD_amount INT         -- số lượng cũ
	DECLARE @OLD_ID_inputCoupon INT   --ID phiếu nhập cũ
	DECLARE @OLD_ID_Medicine INT		-- id thuốc cũ

	-- delete
	SELECT
		@OLD_intoMoney = IntoMoney,
		@OLD_numUnitOutput = NumUnitOutput	,
		@OLD_amount = Amount,
		@OLD_ID_inputCoupon = ID_inputCoupon,
		@OLD_ID_Medicine = ID_Medicine 
	FROM dbo.INPUTCOUPONLINE
	WHERE ID_InputCouponLine = @ID_inputCouponLine

	SET @totalNumUnitOutput = @OLD_numUnitOutput * @OLD_amount
	 
	UPDATE dbo.MEDICINE SET TotalInventory = TotalInventory - @totalNumUnitOutput
	WHERE ID_Medicine = @OLD_ID_Medicine
		
	UPDATE dbo.INPUTCOUPON 
	SET TotalMoney = TotalMoney - @OLD_intoMoney
	WHERE ID_InputCoupon = @OLD_ID_inputCoupon

	
	--insert
	DECLARE @intoMoney DECIMAL(12,0)
	SET @intoMoney = @price * @amount
	SET @totalNumUnitOutput = @numUnitOutput * @amount
	-- Cập nhât INPUTCOUPONLINE
	UPDATE dbo.INPUTCOUPONLINE SET [ID_InputCoupon] = @ID_inputCoupon, [ID_Medicine] = @ID_medicine, [Name] = @name, [UnitInput] = @unitInput, [Amount]= @amount, [Price] = @price , [ExpiryDate] = @expiryDate, [NumUnitOutput] = @numUnitOutput , [productionBatch] = @productionBatch , [IntoMoney] = @intoMoney --TRUONG EDIT HERE
	WHERE ID_InputCouponLine = @ID_inputCouponLine

	SET @totalNumUnitOutput = @numUnitOutput * @amount
	
	UPDATE dbo.INPUTCOUPON SET TotalMoney = TotalMoney + @intoMoney
	WHERE ID_InputCoupon = @ID_inputCoupon
	
	UPDATE dbo.MEDICINE SET TotalInventory = TotalInventory + @totalNumUnitOutput
	WHERE ID_Medicine = @ID_medicine
END
GO


--------------------------

-- Update PRESCRIPTIONLINE
CREATE PROC UpdatePRESCRIPTIONLINE (@ID_prescription INT, @ID_medicine INT, @amount INT, @healthInsurance DECIMAL(10,0))
AS
BEGIN		 
	DECLARE @OLD_healthInsurance DECIMAL(10,0)  -- tiền bảo hiểm cũ
	DECLARE @OLD_amount INT				   -- số lượng cũ	
	DECLARE @OLD_intoMoney DECIMAL(10,0)    -- Thành tiền cũ
	SELECT
		@OLD_healthInsurance = HealthInsurance,
		@OLD_amount = Amount,
		@OLD_intoMoney = IntoMoney
	FROM dbo.PRESCRIPTIONLINE
	WHERE ID_Prescription = @ID_prescription AND ID_Medicine = @ID_medicine

	DECLARE @price DECIMAL
	SELECT @price = Price FROM dbo.MEDICINE WHERE ID_Medicine = @ID_medicine

	DECLARE @intoMoney DECIMAL(10,0)
	SET @intoMoney = @price * @amount - @healthInsurance

	UPDATE dbo.PRESCRIPTION
	SET TotalMoney = TotalMoney - @OLD_intoMoney +  @intoMoney
	WHERE ID_Prescription = @ID_prescription

	UPDATE dbo.MEDICINE
	SET TotalInventory = TotalInventory - @amount + @OLD_amount
	WHERE ID_Medicine =  @ID_medicine
	
	UPDATE dbo.PRESCRIPTIONLINE SET [Amount] = @amount, HealthInsurance = @healthInsurance, [IntoMoney]= @intoMoney
	WHERE [ID_Prescription] = @ID_prescription AND [ID_Medicine] = @ID_medicine
END
GO

CREATE TRIGGER TG_DEL_SUPPLIER ON SUPPLIER
INSTEAD OF DELETE
AS
BEGIN	
	DELETE FROM dbo.INPUTCOUPON WHERE INPUTCOUPON.ID_Supplier IN
	( SELECT deleted.ID_Supplier  FROM  deleted)
	DELETE FROM dbo.SUPPLIER WHERE ID_Supplier IN
	( SELECT deleted.ID_Supplier  FROM  deleted)	
END
GO

CREATE TRIGGER TG_DEL_INPUTCOUPON ON INPUTCOUPON
INSTEAD OF DELETE
AS
BEGIN	
	DELETE FROM dbo.INPUTCOUPONLINE WHERE INPUTCOUPONLINE.ID_InputCoupon IN
	( SELECT deleted.ID_InputCoupon  FROM  deleted)
	DELETE FROM dbo.INPUTCOUPON WHERE ID_InputCoupon IN
	( SELECT deleted.ID_InputCoupon  FROM  deleted)
	
END
GO

CREATE TRIGGER TG_DEL_PRESCRIPTION ON PRESCRIPTION
INSTEAD OF DELETE
AS
BEGIN	
	DELETE FROM dbo.PRESCRIPTIONLINE WHERE PRESCRIPTIONLINE.ID_Prescription IN
	( SELECT deleted.ID_Prescription  FROM  deleted)
	DELETE FROM dbo.PRESCRIPTION WHERE ID_Prescription IN
	( SELECT deleted.ID_Prescription  FROM  deleted)	
END
GO

CREATE TRIGGER TG_DEL_MEDICINE ON MEDICINE
INSTEAD OF DELETE
AS
BEGIN	
	DELETE FROM dbo.INPUTCOUPONLINE WHERE INPUTCOUPONLINE.ID_Medicine IN
	( SELECT deleted.ID_Medicine  FROM  deleted)
	DELETE FROM dbo.PRESCRIPTIONLINE WHERE PRESCRIPTIONLINE.ID_Medicine IN
	( SELECT deleted.ID_Medicine  FROM  deleted)
	DELETE FROM dbo.MEDICINE WHERE ID_Medicine IN
	( SELECT deleted.ID_Medicine  FROM  deleted)	
END
GO


--------------------------------INSERT DATA------------------------------

-------NHÀ CUNG CẤP
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP DƯỢC HẬU GIANG',N'Hậu Giang','haugiang@gmail.com','0975795610')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP TRAPHACO',N'Hà Nội','traphaco@gmail.com','0975795611')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP PYMEPHARCO','TP.HCM','pymepharcog@gmail.com','0975795612')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP DOMESCO',N'Hà Giang','domesco@gmail.com','0975795613')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP IMEXPHARM',N'Lai Châu','imexpharm@gmail.com','0975795614')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP DƯỢC BÌNH ĐỊNH',N'Bình Định','duocphambd@gmail.com','0975795615')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP DƯỢC OPC',N'Bắc Giang','duocphamopc@gmail.com','0975795616')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP AVENTIS VIỆT NAM',N'Kiên Giang','aventisvn@gmail.com','0975795617')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP DƯỢC HÀ TÂT',N'Hà Tây','duocphamht@gmail.com','0975795618')
INSERT INTO [dbo].[SUPPLIER](Name,Address,Email,Phone) VALUES (N'CÔNG TY CP MEKOPHAR',N'Hà Nam','mekophar@gmail.com','0975795619')
GO

-------PHIẾU NHẬP
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),1,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),2,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),3,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),4,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),5,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),6,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),7,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),8,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),9,NULL)
INSERT INTO [dbo].[INPUTCOUPON](CreateDate,ID_Supplier,TotalMoney) VALUES (GETDATE(),10,NULL)
GO
--đoạn dưới ae viết hàm cập nhật tổng tiền dựa trên dòng phiếu Nhập

------THUỐC
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Penicillin',N'uống',N'điều trị viêm phổi,sát khuẩn họng...',N'vỉ',100000,100,1,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'Vắc-xin đậu mùa',N'tiêm',N'điều trị đậu mùa...',N'mũi tiêm',100000,100,2,N'tiêm theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Insulin',N'uống',N'điều trị tiểu đường...',N'chai',100000,100,3,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Morphin',N'uống',N'giảm đau ...',N'vỉ',100000,100,4,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Aspirin',N'uống',N'giảm đau tim,kháng viêm...',N'vỉ',100000,100,5,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'Vắc-xin bại liệt',N'tiêm',N'điều trị bại liệt...',N'mũi tiêm',100000,100,6,N'tiêm theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Chlorpromazin',N'uống',N'an thần...',N'vỉ',100000,100,7,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'hóa trị liệu ung thư',N'uống',N'điều trị ung thư bạch cầu...',N'vỉ',100000,100,8,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'chất ức chế protease điều trị HIV',N'uống',N'điều trị HIV/AIDS...',N'vỉ',100000,100,9,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Ether',N'uống',N'gây mê...',N'vỉ',100000,100,10,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Paracetamol ',N'uống',N'giảm đau đầu,hạ sốt...',N'vỉ',100000,100,11,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Amodiaquine',N'uống',N'điều trị sốt rét...',N'vỉ',100000,100,12,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'Thuốc kháng histamin',N'uống',N'điều trị phát ban ngứa,dị ứng...',N'vỉ',100000,100,1,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'Thuốc ho,cảm cúm',N'bôi ngoài da',N'sát khuẩn,ngăn nhiễm trùng...',N'tuýp',100000,100,2,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'Thuốc mỡ kháng khuẩn','uống',N'điều trị viêm phổi,sát khuẩn họng...',N'vỉ',100000,100,3,N'Bôi theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES (N'Dung Dịch Oxy già',N'Dung dịch rửa vết thương',N'sát khuẩn,sát trùng vết thương...','chai',100000,100,4,N'rửa vết thương theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('salonPat',N'Miếng Dán',N'điều trị đau cơ,sưng cơ...',N'túi',100000,100,5,N'dán vào chỗ bị sưng tấy theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Diazepam',N'uống',N'chống co giật...',N'vỉ',100000,100,6,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Albendazole',N'uống',N'thuốc chống giun trong đường ruột...',N'vỉ',100000,100,7,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Ethambutol',N'uống',N'điều trị lao phổi...',N'vỉ',100000,100,8,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Clofazimine',N'uống',N'điều trị phong tê thấp...',N'vỉ',100000,100,9,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Amphotericin B',N'uống',N'chống nấm...',N'vỉ',100000,100,10,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Aciclovir',N'uống',N'thuốc chống virus herpes...',N'vỉ',100000,100,11,N'uống theo chỉ định của bác sĩ')
INSERT INTO [dbo].[MEDICINE](Name,MedicineGroup,Uses,Unit,Price,TotalInventory,MostUsedMonth,Note) VALUES ('Tenofovir disoproxil fumarate',N'uống',N'điều trị viêm gan B...',N'vỉ',100000,100,12,N'uống theo chỉ định của bác sĩ')
GO
-------DÒNG PHIẾU NHẬP
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Penicillin',N'hộp',10,1000000,'2030-12-12',10,1,10000000,1,1)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'Vắc-xin đậu mùa',N'hộp',10,1000000,'2030-12-12',10,1,10000000,1,2)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Insulin',N'hộp',10,1000000,'2030-12-12',10,1,10000000,1,3)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Morphin',N'hộp',10,1000000,'2030-12-12',10,1,10000000,2,4)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Aspirin',N'hộp',10,1000000,'2030-12-12',10,1,10000000,2,5)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'Vắc-xin bại liệt',N'hộp',10,1000000,'2030-12-12',10,1,10000000,2,6)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Chlorpromazin',N'hộp',10,1000000,'2030-12-12',10,1,10000000,3,7)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'hóa trị liệu ung thư',N'hộp',10,1000000,'2030-12-12',10,1,10000000,3,8)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'chất ức chế protease điều trị HIV',N'hộp',10,1000000,'2030-12-12',10,1,10000000,3,9)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Ether',N'hộp',10,1000000,'2030-12-12',10,1,10000000,4,10)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Paracetamol',N'hộp',10,1000000,'2030-12-12',10,1,10000000,4,11)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Amodiaquine',N'hộp',10,1000000,'2030-12-12',10,1,10000000,4,12)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'Thuốc kháng histamin',N'hộp',10,1000000,'2030-12-12',10,1,10000000,5,13)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'Thuốc ho,cảm cúm',N'hộp',10,1000000,'2030-12-12',10,1,10000000,5,14)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'Thuốc mỡ kháng khuẩn',N'hộp',10,1000000,'2030-12-12',10,1,10000000,6,15)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES (N'Dung Dịch Oxy già',N'hộp',10,1000000,'2030-12-12',10,1,10000000,6,16)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('salonPat',N'hộp',10,1000000,'2030-12-12',10,1,10000000,7,17)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Diazepam',N'hộp',10,1000000,'2030-12-12',10,1,10000000,8,18)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Albendazole','hộp',10,1000000,'2030-12-12',10,1,10000000,8,19)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Ethambutol','hộp',10,1000000,'2030-12-12',10,1,10000000,8,20)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Clofazimine',N'hộp',10,1000000,'2030-12-12',10,1,10000000,9,21)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Amphotericin',N'hộp',10,1000000,'2030-12-12',10,1,10000000,9,22)

INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Aciclovir',N'hộp',10,1000000,'2030-12-12',10,1,10000000,10,23)
INSERT INTO [dbo].[INPUTCOUPONLINE](Name,UnitInput,Amount,Price,ExpiryDate,NumUnitOutput,ProductionBatch,IntoMoney,ID_InputCoupon,ID_Medicine)
VALUES ('Tenofovir disoproxil fumarate',N'hộp',10,1000000,'2030-12-12',10,1,10000000,10,24)
GO

-------ĐƠN THUỐC
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Phùng Văn Trường',GETDATE(),1,1,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Phùng Văn Trường',GETDATE(),2,2,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Phùng Văn Trường',GETDATE(),3,3,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Nguyễn Đức Hưng',GETDATE(),1,1,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Nguyễn Đức Hưng',GETDATE(),2,2,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Nguyễn Đức Hưng',GETDATE(),3,3,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Vũ Minh Hiếu',GETDATE(),7,1,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Vũ Minh Hiếu',GETDATE(),8,2,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Vũ Minh Hiếu',GETDATE(),9,3,NULL)
INSERT INTO [dbo].[PRESCRIPTION] (Doctor,CreateDate,MedicalRecord,Drugstores,TotalMoney) VALUES(N'Nguyễn Hữu Tiến',GETDATE(),10,4,NULL)
GO

-------DÒNG ĐƠN THUỐC

INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (1,1,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (1,2,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (1,3,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (2,4,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (2,5,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (2,6,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (3,7,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (3,8,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (3,9,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (4,10,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (4,11,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (4,12,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (5,13,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (5,14,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (6,15,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (6,16,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (7,17,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (7,18,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (8,19,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (8,20,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (9,21,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (9,22,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (10,23,10,500000,500000)
INSERT INTO [dbo].[PRESCRIPTIONLINE] (ID_Prescription,ID_Medicine,Amount,HealthInsurance,IntoMoney) VALUES (10,24,10,500000,500000)
GO


-----UPDATE TỔNG TIỀN PHIẾU NHẬP
UPDATE [dbo].INPUTCOUPON
 set TotalMoney =  (Select SUM(IntoMoney) from [dbo].INPUTCOUPONLINE where INPUTCOUPON.ID_InputCoupon = INPUTCOUPONLINE.ID_InputCoupon)

-----UPDATE TỔNG TIỀN ĐƠN THUỐC
UPDATE [dbo].PRESCRIPTION 
set TotalMoney =  (Select SUM(IntoMoney) from [dbo].PRESCRIPTIONLINE where PRESCRIPTION.ID_Prescription = PRESCRIPTIONLINE.ID_Prescription)