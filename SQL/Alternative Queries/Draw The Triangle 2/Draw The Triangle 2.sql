/*
Working Platform:- MSSQL
*/

DECLARE @i INT = 20;
DECLARE @j INT = 1;

WHILE (@j <= @i)
BEGIN
    PRINT REPLICATE('* ', @j);
    SET @j = @j + 1;
END
