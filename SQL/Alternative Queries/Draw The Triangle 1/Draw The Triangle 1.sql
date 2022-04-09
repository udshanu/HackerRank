/*
Working Platform:- MSSQL
*/

DECLARE @starCount INT = 20;
WHILE (@starCount > 0)
BEGIN
    PRINT REPLICATE('* ', @starCount);
    SET @starCount = @starCount - 1;
END



/*
Working Platform:- MySQL
*/

SET @TEMP:=21; 
SELECT REPEAT('* ', @TEMP:= @TEMP - 1) 
FROM INFORMATION_SCHEMA.TABLES;

