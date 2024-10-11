/* Write your T-SQL query statement below */
sELECT distinct a.num ConsecutiveNums FROM Logs A JOIN Logs B
                                                       ON A.id = B.ID+1
                                                  JOIN LOGS C
                                                       ON b.id = c.id +1
where a.num =b.num and b.num =c.num