USE [SQLProject@1];
IF OBJECT_ID('Student', 'U') IS NOT NULL DROP TABLE Student;
IF OBJECT_ID('Professor', 'U') IS NOT NULL DROP TABLE Professor;
IF OBJECT_ID('Department', 'U') IS NOT NULL DROP TABLE Department;
IF OBJECT_ID('College', 'U') IS NOT NULL DROP TABLE College;
IF OBJECT_ID('University', 'U') IS NOT NULL DROP TABLE University;

CREATE TABLE University (
    UniversityId INT PRIMARY KEY,
    UniversityName VARCHAR(100) NOT NULL,
    UniversityType VARCHAR(50),
    UniversityGrade CHAR(1),
    UniversityAddress VARCHAR(200)
);

CREATE TABLE College (
    CollegeId INT PRIMARY KEY,
    CollegeName VARCHAR(100) NOT NULL,
    CollegeType VARCHAR(50),
    CollegeAddress VARCHAR(200),
    UniversityId INT FOREIGN KEY REFERENCES University(UniversityId)
);

CREATE TABLE Department (
    DepartmentId INT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL,
    NumberOfClass INT,
    DepartmentHead VARCHAR(100),
    CollegeId INT FOREIGN KEY REFERENCES College(CollegeId)
);

CREATE TABLE Professor (
    ProfessorId INT PRIMARY KEY,
    ProfessorName VARCHAR(100),
    ProfessorAddress VARCHAR(200),
    ProfessorAge INT,
    Salary DECIMAL(10,2),
    DepartmentId INT FOREIGN KEY REFERENCES Department(DepartmentId)
);

CREATE TABLE Student (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(100),
    StudentAddress VARCHAR(200),
    Age INT,
    StudentPercentage DECIMAL(5,2),
    StudentMarks INT,
    StudentResult VARCHAR(10),
    DepartmentId INT FOREIGN KEY REFERENCES Department(DepartmentId)
);
