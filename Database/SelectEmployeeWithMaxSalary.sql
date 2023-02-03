SELECT TOP 1 e.Name, d.Name  
FROM Employees e 
WHERE Salary= 
(SELECT MAX(Salary) 
FROM Employees) 
LEFT JOIN Departments d 
ON d.Id == e.DepartmentId 