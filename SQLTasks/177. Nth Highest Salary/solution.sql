CREATE FUNCTION getNthHighestSalary(@N INT)
    RETURNS INT
    AS
BEGIN
    RETURN (
               SELECT Salary
               FROM (
                        SELECT DISTINCT Salary, DENSE_RANK() OVER (ORDER BY Salary DESC) AS RowNum
                        FROM Employee
                    ) AS RankedSalaries
               WHERE RowNum = @N
           );
END;