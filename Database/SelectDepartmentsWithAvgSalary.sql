SELECT *  
FROM Departments 
WHERE Id in 
(SELECT DepartmentId  
FROM Employees
GROUP by DepartmentId 
WHERE AVG (Salary)> 1000)