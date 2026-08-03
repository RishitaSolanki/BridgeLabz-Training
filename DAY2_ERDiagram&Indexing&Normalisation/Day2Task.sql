use HealthClinicDB;
Go

SELECT * FROM INFORMATION_SCHEMA.TABLES;

/*Task 1: Add Rooms table and Doctor_Room Relationship*/
CREATE TABLE Rooms(
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber VARCHAR(20) NOT NULL,
    FloorNumber INT,
    RoomType VARCHAR(50)
);

INSERT INTO Rooms(RoomNumber, FloorNumber, RoomType)
VALUES
('101',1,'General Ward'),
('102',1,'Emergency'),
('201',2,'Cardiology'),
('301',3,'Dermatologist');

SELECT * FROM Rooms;

CREATE TABLE Doctor_Room(
    DoctorID INT,
    RoomID INT,
    AssignedDate DATE,
    PRIMARY KEY(DoctorID, RoomID),

    FOREIGN KEY(DoctorID)
    REFERENCES Doctor(DoctorID),
    FOREIGN KEY(RoomID)
    REFERENCES Rooms(RoomID)
);

INSERT INTO Doctor
(FirstName, LastName, Specialization, Phone)
VALUES
('Rishita','Solanki','Cardiologist','9876543210'),
('Rama','Singh','dermatologist','9876543211'),
('Ram','verma','Neurologist','9876543212');

SELECT * FROM Doctor;

INSERT INTO Doctor_Room
(DoctorID, RoomID, AssignedDate)
VALUES
(1,3,'2026-08-03'),
(2,1,'2026-08-04'),
(3,2,'2026-08-03');

SELECT * FROM Doctor_Room;

SELECT D.FirstName, D.LastName,
       R.RoomNumber, R.RoomType,
       DR.AssignedDate
FROM Doctor_Room DR
JOIN Doctor D
ON DR.DoctorID = D.DoctorID
JOIN Rooms R
ON DR.RoomID = R.RoomID;

/*Task 2: EXPLAIN Queries on Appointment Table*/

INSERT INTO Patient(FirstName, LastName, DateOfBirth, Gender, Phone, Address)
VALUES
('Amit','Sharma','1995-05-10','M','9000000001','Delhi'),
('Priya','Patel','1998-08-15','F','9000000002','Mumbai'),
('Rahul','Verma','1992-12-20','M','9000000003','Pune');

SELECT * FROM Patient;

INSERT INTO Appointment(PatientID, DoctorID, AppointmentDate, TimeSlot, Status)
VALUES
(2,1,'2026-08-05','10:00:00','Completed'),
(3,2,'2026-08-06','11:30:00','Pending'),
(1,3,'2026-08-07','02:00:00','Cancelled'),
(2,1,'2026-08-08','04:30:00','Pending');

SELECT * FROM Appointment;

SELECT * FROM Appointment WHERE DoctorID = 2;

CREATE INDEX idx_appointment_doctor ON Appointment(DoctorID);
SELECT * FROM Appointment WHERE DoctorID = 2;

CREATE INDEX idx_doctor_status ON Appointment(DoctorID, Status);
SELECT * FROM Appointment WHERE DoctorID=1 AND Status='Completed';

/*Task 3: Normalize Patient Phones Table*/

CREATE TABLE Patient_Phones(PatientID INT, PhoneNumber VARCHAR(15),
    PRIMARY KEY(PatientID, PhoneNumber),
    FOREIGN KEY(PatientID)
    REFERENCES Patient(PatientID)
);

INSERT INTO Patient_Phones(PatientID, PhoneNumber)
VALUES
(2,'9876543210'),
(2,'9123456789'),
(3,'9988776655'),
(1,'9012345678'),
(1,'9098765432');

SELECT * FROM Patient_Phones;

/*Task 4: Covering Index*/

CREATE INDEX idx_covering_appointment
ON Appointment(DoctorID,AppointmentDate,Status);

SELECT DoctorID,AppointmentDate,Status FROM Appointment;

