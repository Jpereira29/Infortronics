DECLARE @nasc as varchar(11)='17/04/2008'
SELECT @nasc, DATEDIFF(YY, @nasc, GETDATE())
