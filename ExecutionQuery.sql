-- =========================================================
-- 5. Assignment Queries
-- =========================================================

-- 1. Students belonging to University 'AAAAAA'
SELECT s.StudentId, s.StudentName, s.StudentAddress, s.Age, s.StudentPercentage, s.StudentMarks, s.StudentResult
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
WHERE u.UniversityName LIKE 'AAAAAA%';

-- 2. Group students university-wise, college-wise, department-wise
SELECT u.UniversityName, c.CollegeName, d.DepartmentName, COUNT(s.StudentId) AS TotalStudents
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
GROUP BY u.UniversityName, c.CollegeName, d.DepartmentName
ORDER BY u.UniversityName, c.CollegeName, d.DepartmentName;

-- 3. Professors with salary > 50,000 along with University, College, Department
SELECT u.UniversityName, c.CollegeName, d.DepartmentName, p.ProfessorId, p.ProfessorName, p.ProfessorAddress, p.ProfessorAge, p.Salary
FROM Professor p
JOIN Department d ON p.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
WHERE p.Salary > 50000
ORDER BY p.Salary DESC;

-- 4. Sum of salary for University 'BBBBBB'
SELECT u.UniversityName, SUM(p.Salary) AS TotalSalary
FROM Professor p
JOIN Department d ON p.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
WHERE u.UniversityName LIKE 'BBBBBB%'
GROUP BY u.UniversityName;

-- 5. Count of students university-wise by division
SELECT u.UniversityName, s.StudentResult, COUNT(s.StudentId) AS TotalStudents
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
GROUP BY u.UniversityName, s.StudentResult
ORDER BY u.UniversityName, s.StudentResult;

-- 6. Students in 'Computer Science' department
SELECT s.StudentId, s.StudentName, s.StudentAddress, s.Age, s.StudentPercentage, s.StudentMarks, s.StudentResult
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
WHERE d.DepartmentName = 'Computer Science';

-- 7. University of student with maximum marks
SELECT TOP 1 u.UniversityName, s.StudentName, s.StudentMarks
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
ORDER BY s.StudentMarks DESC;

-- 8. Students in grade 'A' University
SELECT s.StudentId, s.StudentName, u.UniversityName, u.UniversityGrade
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
WHERE u.UniversityGrade = 'A';

-- 9. Percentage of passed students in University 'AAAAAA'
SELECT u.UniversityName,
    CAST(SUM(CASE WHEN s.StudentResult IN ('First','Second','Third') THEN 1 ELSE 0 END) * 100.0 / COUNT(s.StudentId) AS DECIMAL(5,2)) AS PassedPercentage
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
JOIN University u ON c.UniversityId = u.UniversityId
WHERE u.UniversityName LIKE 'AAAAAA%'
GROUP BY u.UniversityName;

-- 10. Percentage of passed students college-wise
SELECT c.CollegeName,
    CAST(SUM(CASE WHEN s.StudentResult IN ('First','Second','Third') THEN 1 ELSE 0 END) * 100.0 / COUNT(s.StudentId) AS DECIMAL(5,2)) AS PassedPercentage
FROM Student s
JOIN Department d ON s.DepartmentId = d.DepartmentId
JOIN College c ON d.CollegeId = c.CollegeId
GROUP BY c.CollegeName
ORDER BY c.CollegeName;