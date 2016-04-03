USE HackCompany

--Select the big boss
SELECT *
FROM Employees
WHERE EmployeeID = 1;

--Select all department managers
SELECT * 
FROM Employees
WHERE MANAGER = 1;

--Select all employees in the Sales department ordered by Name
SELECT Employees.FirstName, LastName 
FROM Employees JOIN Departments ON Employees.Department = Departments.DepartmentID
WHERE Departments.Name = 'SALES'
ORDER BY FirstName, LastName;

--Select all departments with employees that are born after 1990
SELECT DISTINCT Departments.Name
FROM Departments JOIN Employees ON Employees.Department = Departments.DepartmentID
WHERE Employees.DateOfBirth >= '1990-01-01';

--Select all departments with more than 3 employees
SELECT Departments.Name 
FROM Departments JOIN Employees ON Employees.Department = Departments.DepartmentID
GROUP BY Departments.DepartmentID, Departments.Name HAVING COUNT(*) > 3;

--Select the department having the most employees
SELECT Name
FROM Departments JOIN Employees ON Departments.DepartmentID = Employees.Department
GROUP BY Departments.DepartmentID, Departments.Name
ORDER BY COUNT(*) DESC

--Update all employees adding 1 year to their birth date
UPDATE Employees
SET DateOfBirth = DATEADD(YEAR, 1, DATEOFBIRTH);

--Delete all products with no order
DELETE 
FROM Products 
WHERE ProductID NOT IN (SELECT ProductID FROM OrderProducts);