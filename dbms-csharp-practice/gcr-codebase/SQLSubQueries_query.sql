create database SubQueriesDB
USE SubQueriesDB;

CREATE TABLE Patients (PatientID INT PRIMARY KEY, Name NVARCHAR(50));
CREATE TABLE Specialties (SpecialtyId INT PRIMARY KEY, SpecialtyName NVARCHAR(50));
CREATE TABLE Doctors (DoctorId INT PRIMARY KEY, DoctorName NVARCHAR(50), SpecialtyId INT, ConsultationFee DECIMAL(10,2));
CREATE TABLE Appointments (AppointmentId INT PRIMARY KEY, PatientID INT, DoctorId INT, AppointmentDate DATETIME);

INSERT INTO Patients VALUES (1, 'John Doe'), (2, 'Jane Smith'), (3, 'Mike Ross');
INSERT INTO Specialties VALUES (10, 'Cardiology'), (20, 'Dermatology');
INSERT INTO Doctors VALUES (101, 'Dr. Adams', 10, 500), (102, 'Dr. Baker', 20, 400), (103, 'Dr. Clark', 10, 600);
INSERT INTO Appointments VALUES (1, 1, 101, '2023-10-01'), (2, 1, 103, '2023-10-05'), (3, 2, 102, '2023-10-10');



---------------------------------------------------------
-- 1. SUBQUERY IN WHERE CLAUSE
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM Table WHERE Col IN (SELECT Col FROM Table2 WHERE ...);

SELECT Name FROM Patients
WHERE PatientID IN (
    SELECT PatientID FROM Appointments
    WHERE DoctorId IN (
        SELECT DoctorId FROM Doctors
        WHERE SpecialtyId = (SELECT SpecialtyId FROM Specialties WHERE SpecialtyName = 'Cardiology')
    )
);

---------------------------------------------------------
-- 2. SUBQUERY IN FROM CLAUSE (Derived Table)
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM (SELECT ... ) AS AliasName WHERE ...;

SELECT DocName, TotalAppointments
FROM (
    SELECT D.DoctorName AS DocName, COUNT(*) AS TotalAppointments
    FROM Appointments A
    JOIN Doctors D ON A.DoctorId = D.DoctorId
    GROUP BY D.DoctorName
) AS DoctorCounts
WHERE TotalAppointments >= 1;

---------------------------------------------------------
-- 3. SUBQUERY IN SELECT CLAUSE (Scalar Subquery)
---------------------------------------------------------
-- SYNTAX: SELECT Col1, (SELECT ... ) AS NewCol FROM Table;

SELECT Name, 
    (SELECT COUNT(*) FROM Appointments A WHERE A.PatientId = P.PatientID) AS TotalAppointments
FROM Patients P;



---------------------------------------------------------
-- 4. CORRELATED SUBQUERY
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM Table T WHERE (SELECT ... WHERE Inner.ID = T.ID) > (Outer Aggregate);


SELECT DoctorName FROM Doctors D
WHERE (
    SELECT COUNT(*) FROM Appointments A WHERE A.DoctorId = D.DoctorId
) > (
    SELECT AVG(AppointmentCount) FROM (
        SELECT COUNT(*) AS AppointmentCount FROM Appointments GROUP BY DoctorId
    ) AS AvgCounts
);

---------------------------------------------------------
-- 5. USING EXISTS
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM Table T WHERE EXISTS (SELECT 1 FROM Table2 WHERE ...);


SELECT DoctorName FROM Doctors D
WHERE EXISTS (
    SELECT 1 FROM Appointments A WHERE A.DoctorId = D.DoctorId
);

---------------------------------------------------------
-- 6. USING NOT EXISTS
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM Table T WHERE NOT EXISTS (SELECT 1 FROM Table2 WHERE ...);

SELECT Name FROM Patients P
WHERE NOT EXISTS (
    SELECT 1 FROM Appointments A WHERE A.PatientId = P.PatientID
);



 DROP TABLE Appointments;
 DROP TABLE Doctors;
 DROP TABLE Specialties;
 DROP TABLE Patients;