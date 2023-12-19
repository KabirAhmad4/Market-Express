
-- Create an audit table for the Users table
CREATE TABLE Audit.Users_Audit (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    AuditDate DATETIME DEFAULT GETDATE(),
    AuditUser NVARCHAR(128) DEFAULT dbo.GetCurrentUser(),
    AuditOperation NVARCHAR(10),
    UserID INT,
    UserName VARCHAR(255) NOT NULL,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Gender VARCHAR(50),
    Contact VARCHAR(255) NOT NULL,
    UserRoles VARCHAR(255) NOT NULL
);

-- Create a trigger for the Users table (INSERT, UPDATE, DELETE)
CREATE TRIGGER tr_Users_Audit
ON dbo.Users
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture DELETE operation
        INSERT INTO Audit.Users_Audit (AuditOperation, UserID, UserName, FirstName, LastName, Email, Gender, Contact, UserRoles)
        SELECT 'DELETE', UserID, UserName, FirstName, LastName, Email, Gender, Contact, UserRoles FROM deleted;
    END;

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture INSERT or UPDATE operation
        INSERT INTO Audit.Users_Audit (AuditOperation, UserID, UserName, FirstName, LastName, Email, Gender, Contact, UserRoles)
        SELECT 
            CASE 
                WHEN EXISTS (SELECT * FROM deleted d WHERE d.UserID = i.UserID) THEN 'UPDATE'
                ELSE 'INSERT'
            END,
            i.UserID, i.UserName, i.FirstName, i.LastName, i.Email, i.Gender, i.Contact, i.UserRoles
        FROM inserted i;
    END;
END;














-- Create an audit table for the Products table


CREATE TABLE Audit.Products_Audit (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    AuditDate DATETIME DEFAULT GETDATE(),
    AuditUser NVARCHAR(128) DEFAULT dbo.GetCurrentUser(),
    AuditOperation NVARCHAR(10),
    ProductID INT,
    AddedByUserID INT,
    Name VARCHAR(255) NOT NULL,
    Description varchar(Max),
    ProductCategory VARCHAR(255) NOT NULL,
    Price DECIMAL(10, 2) CHECK (Price > 0 AND Price < 1000000),
    Quantity INT NOT NULL,
    LikesCount INT,
    ReviewsCount INT,
    Available BIT
);

-- Alter the Products table to change the Description attribute to VARCHAR(MAX)
ALTER TABLE Communications
ALTER COLUMN Message_txt VARCHAR(MAX);


-- Create a trigger for the Products table (INSERT, UPDATE, DELETE)
CREATE TRIGGER  tr_Products_Audit
ON dbo.Products
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture DELETE operation
        INSERT INTO Audit.Products_Audit (AuditOperation, ProductID, AddedByUserID, Name, Description, ProductCategory, Price, Quantity, LikesCount, ReviewsCount, Available)
        SELECT 'DELETE', ProductID, AddedByUserID, Name, Description, ProductCategory, Price, Quantity, LikesCount, ReviewsCount, Available FROM deleted;
    END;

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture INSERT or UPDATE operation
        INSERT INTO Audit.Products_Audit (AuditOperation, ProductID, AddedByUserID, Name, Description, ProductCategory, Price, Quantity, LikesCount, ReviewsCount, Available)
        SELECT 
            CASE 
                WHEN EXISTS (SELECT * FROM deleted d WHERE d.ProductID = i.ProductID) THEN 'UPDATE'
                ELSE 'INSERT'
            END,
            i.ProductID, i.AddedByUserID, i.Name, i.Description, i.ProductCategory, i.Price, i.Quantity, i.LikesCount, i.ReviewsCount, i.Available
        FROM inserted i;
    END;
END;




-- Create an audit table for the Billing table
CREATE TABLE Audit.Billing_Audit (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    AuditDate DATETIME DEFAULT GETDATE(),
    AuditUser NVARCHAR(128) DEFAULT dbo.GetCurrentUser(),
    AuditOperation NVARCHAR(10),
    BillingID INT,
    OrdersID INT,
    TotalPrice DECIMAL,
    AmountRecived DECIMAL,
    AmountReturned DECIMAL,
    DateOfBilling DATETIME
);

















-- Create a trigger for the Billing table (INSERT, UPDATE, DELETE)
CREATE TRIGGER tr_Billing_Audit
ON dbo.Billing
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture DELETE operation
        INSERT INTO Audit.Billing_Audit (AuditOperation, BillingID, OrdersID, TotalPrice, AmountRecived, AmountReturned, DateOfBilling)
        SELECT 'DELETE', BillingID, OrdersID, TotalPrice, AmountRecived, AmountReturned, DateOfBilling FROM deleted;
    END;

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture INSERT or UPDATE operation
        INSERT INTO Audit.Billing_Audit (AuditOperation, BillingID, OrdersID, TotalPrice, AmountRecived, AmountReturned, DateOfBilling)
        SELECT 
            CASE 
                WHEN EXISTS (SELECT * FROM deleted d WHERE d.BillingID = i.BillingID) THEN 'UPDATE'
                ELSE 'INSERT'
            END,
            i.BillingID, i.OrdersID, i.TotalPrice, i.AmountRecived, i.AmountReturned, i.DateOfBilling
        FROM inserted i;
    END;
END;

drop TRIGGER tr_Communications_Audit
drop TABLE Audit.Communications_Audit 


-- Create an audit table for the Communications table
CREATE TABLE Audit.Communications_Audit (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    AuditDate DATETIME DEFAULT GETDATE(),
    AuditUser NVARCHAR(128) DEFAULT dbo.GetCurrentUser(),
    AuditOperation NVARCHAR(10),
    CommunicationID INT,
    Sender INT,
    Receiver INT,
    Message_txt varchar(max),
    Date DATETIME NOT NULL
);

-- Create a trigger for the Communications table (INSERT, UPDATE, DELETE)
CREATE TRIGGER tr_Communications_Audit
ON dbo.Communications
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture DELETE operation
        INSERT INTO Audit.Communications_Audit (AuditOperation, CommunicationID, Sender, Receiver, Message_txt, Date)
        SELECT 'DELETE', CommunicationID, Sender, Receiver, Message_txt, Date FROM deleted;
    END;

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Capture INSERT or UPDATE operation
        INSERT INTO Audit.Communications_Audit (AuditOperation, CommunicationID, Sender, Receiver, Message_txt, Date)
        SELECT 
            CASE 
                WHEN EXISTS (SELECT * FROM deleted d WHERE d.CommunicationID = i.CommunicationID) THEN 'UPDATE'
                ELSE 'INSERT'
            END,
            i.CommunicationID, i.Sender, i.Receiver, i.Message_txt, i.Date
        FROM inserted i;
    END;
END;








