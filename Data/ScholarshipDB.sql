CREATE DATABASE ScholarshipDB;
USE ScholarshipDB;


--Bảng Users (Lưu thông tin tài khoản)
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    PasswordHash NVARCHAR(255),
    Role NVARCHAR(20) CHECK (Role IN ('Student', 'Admin'))
);

--Bảng Scholarships (Lưu thông tin học bổng)
CREATE TABLE Scholarships (
    ScholarshipID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255),
    Description NVARCHAR(MAX),
    Amount DECIMAL(10,2),
    Deadline DATE
);

--Bảng Applications (Lưu hồ sơ đăng ký của sinh viên)
CREATE TABLE Applications (
    ApplicationID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT FOREIGN KEY REFERENCES Users(UserID),
    ScholarshipID INT FOREIGN KEY REFERENCES Scholarships(ScholarshipID),
    Status NVARCHAR(20) CHECK (Status IN ('Pending', 'Approved', 'Rejected')),
    SubmissionDate DATETIME DEFAULT GETDATE()
);


SELECT * FROM Users;
SELECT * FROM Scholarships;
SELECT * FROM Applications;
