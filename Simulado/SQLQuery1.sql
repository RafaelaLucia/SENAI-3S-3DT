BULK INSERT Usuarios
FROM 'C:\usuarios.csv'
WITH (
	FIELDTERMINATOR = ';',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 2,
	CODEPAGE = 'acp'
);

select * from Comentarios