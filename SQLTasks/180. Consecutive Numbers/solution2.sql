WITH Ranked AS (
    SELECT
        num,
        ROW_NUMBER() OVER (ORDER BY id) AS rn,
        ROW_NUMBER() OVER (PARTITION BY num ORDER BY id) AS num_rn
    FROM Logs
),
     Grouped AS (
         SELECT
             num,
             rn - num_rn AS grp
         FROM Ranked
     )
SELECT DISTINCT num AS ConsecutiveNums
FROM Grouped
GROUP BY num, grp
HAVING COUNT(*) >= 3;


