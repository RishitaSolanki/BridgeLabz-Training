use HealthClinicDB;
Go

CREATE TABLE Doctor_Audit(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorID INT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Specialization VARCHAR(100),
    Phone VARCHAR(15),
    ActionType VARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE Patient_Audit(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Phone VARCHAR(15),
    Gender VARCHAR(10),
    DOB DATE,
    ActionType VARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);

/*CREATE THREE TRIGGERS FOR DOCTOR*/
CREATE TRIGGER TRG_Doctor_Insert ON Doctor
AFTER INSERT
AS
BEGIN
INSERT INTO Doctor_Audit
(DoctorID,FirstName,LastName,Specialization,Phone,ActionType)
SELECT
DoctorID,
FirstName,
LastName,
Specialization,
Phone,
'INSERT'
FROM inserted;
END;

CREATE TRIGGER TRG_Doctor_Update ON Doctor
AFTER UPDATE
AS
BEGIN
INSERT INTO Doctor_Audit
(DoctorID,FirstName,LastName,Specialization,Phone,ActionType)
SELECT
DoctorID,
FirstName,
LastName,
Specialization,
Phone,
'UPDATE'
FROM inserted;
END;

CREATE TRIGGER TRG_Doctor_Delete ON Doctor
AFTER DELETE
AS
BEGIN
INSERT INTO Doctor_Audit
(DoctorID,FirstName,LastName,Specialization,Phone,ActionType)
SELECT
DoctorID,
FirstName,
LastName,
Specialization,
Phone,
'DELETE'
FROM deleted;
END;

/*CREATE TRIGGERS FOR PATIENT*/
CREATE TRIGGER TRG_Patient_Insert ON Patient
AFTER INSERT
AS
BEGIN
INSERT INTO Patient_Audit
(PatientID,FirstName,LastName,Phone,Gender,DOB,ActionType)
SELECT
PatientID,
FirstName,
LastName,
Phone,
Gender,
DateOfBirth,
'INSERT'
FROM inserted;
END;

CREATE TRIGGER TRG_Patient_Update ON Patient
AFTER UPDATE
AS
BEGIN
INSERT INTO Patient_Audit
(PatientID,FirstName,LastName,Phone,Gender,DOB,ActionType)
SELECT
PatientID,
FirstName,
LastName,
Phone,
Gender,
DateOfBirth,
'UPDATE'
FROM inserted;
END;

CREATE TRIGGER TRG_Patient_Delete ON Patient
AFTER DELETE
AS
BEGIN
INSERT INTO Patient_Audit
(PatientID,FirstName,LastName,Phone,Gender,DOB,ActionType)
SELECT
PatientID,
FirstName,
LastName,
Phone,
Gender,
DateOfBirth,
'DELETE'
FROM deleted;
END;

SELECT name FROM sys.triggers;