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
	 ID_Medicine int  NOT NULL,
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
CREATE PROC DeleteINPUTCOUPONLINE ( @ID_inputCouponLine INT )
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
	WHERE ID_InputCouponLine = @ID_inputCouponLine

	SET @totalNumUnitOutput = @numUnitOutput * @amount
	 
		
	UPDATE dbo.INPUTCOUPON 
	SET TotalMoney = TotalMoney - @intoMoney
	WHERE ID_InputCoupon = @ID_inputCoupon

	UPDATE dbo.MEDICINE SET TotalInventory = TotalInventory - @totalNumUnitOutput
	WHERE ID_Medicine = @ID_medicine

	DELETE FROM dbo.INPUTCOUPONLINE
	WHERE ID_InputCouponLine = @ID_inputCouponLine

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
CREATE PROC DeletePRESCRIPTIONLINE ( @ID_prescription INT, @ID_medicine INT )
AS
BEGIN
	DECLARE @intoMoney DECIMAL(10,0)
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
CREATE PROC UpdateSUPPLIER(@ID_Supplier INT, @Name NVARCHAR(MAX), @Address NVARCHAR(MAX), @Phone VARCHAR(20), @Email INT)
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
CREATE PROC UpdateINPUTCOUPONLINE (@ID_InputCouponLine INT, @ID_inputCoupon INT, @ID_medicine INT, @name NVARCHAR(100), @unitInput NVARCHAR(50), @amount INT, @price DECIMAL(10,0), @expiryDate DATE, @NumUnitOutput INT, @productionBatch NCHAR(10))
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
	UPDATE dbo.INPUTCOUPONLINE SET [ID_InputCoupon] = @ID_inputCoupon, [ID_Medicine] = @ID_medicine, [Name] = @name, [UnitInput] = @unitInput, [Amount]= @amount, [Price] = @price , [ExpiryDate] = @expiryDate, [NumUnitOutput] = @numUnitOutput , [productionBatch] = @productionBatch
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