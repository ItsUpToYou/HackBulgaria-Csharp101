USE HackCompany

SET IDENTITY_INSERT Departments ON

	INSERT INTO [Departments]([DepartmentID], [Name])
	VALUES (1, 'Sales'), (2, 'Production'), (3, 'Financial');

SET IDENTITY_INSERT Departments OFF

SET IDENTITY_INSERT Employees ON

	INSERT INTO [Employees]([EmployeeID], [FirstName], [LastName], [Email], [DateOfBirth])
	VALUES (1, 'Noa', 'Noeva', 'Noa@gmail.com', '2009-03-17'); 

	INSERT INTO [Employees]([EmployeeID], [FirstName], [LastName], [Email], [DateOfBirth], [MANAGER], [Department])
	VALUES (2, 'Lory', 'Peeva', 'Plevenlieva@gmail.com', '1982-03-14', 1, 1),
		   (3, 'Neli', 'JOrev', 'JOrev@gmail.com', '2002-11-02', 1, 2),
		   (4, 'Ilia', 'Dimkov', 'Dimkov@gmail.com', '1987-05-23', 1, 3);

SET IDENTITY_INSERT Employees OFF

INSERT INTO [Employees]([FirstName], [LastName], [Email], [DateOfBirth], [MANAGER], [Department])
VALUES ('Dim4u', 'Zlatkov', 'botevivan@gmail.com', '2000-12-21', 2, 1),
       ('Nora', 'Nora', 'rumenovapp@gmail.com', '1987-07-25', 2, 1),
	   ('Simo', 'Simo', 'ggyord@gmai.com', '2004-08-29', 2, 1),
	   ('Nik', 'Petrova', 'mariapetrova', '2001-09-17', 2, 1),
	   ('Borko', 'Ivanov', 'tihomiri@gmail.com', '1985-10-19', 2, 1),
	   ('Siana', 'Nikolaeva', 'sisinikolaeva@gmail.com', '2003-02-28', 3, 2),
	   ('Dimov', 'Petrov', 'geshpet@gmail.com', '1989-11-15', 3, 2),
	   ('Sun', 'Stanev', 'stanevr@gmail.com', '2000-04-21', 3, 2),
	   ('Petkana', 'Stoilov', 'milenstoilov@gmail.com', '1989-08-17', 3, 2),
	   ('Ivana', 'Ivanova', 'ivanovaplamena@gmail.com', '2005-07-07', 3, 2),
	   ('Lilana', 'Georgieva', 'ivanageorgieva@gmail.com', '2003-12-17', 4, 3),
	   ('Zlatana', 'Slavova', 'slavovann@gmail.com', '2005-05-09', 4, 3),
	   ('Tihuana', 'Georgieva', 'steligeorg@gmail.com', '1988-12-04', 4, 3),
	   ('Angel', 'Yordanov', 'stefanyordanov@gmail.com', '1987-01-13', 4, 3),
	   ('Morkov', 'Georgiev', 'georgievp@gmail.com', '1979-10-05', 4, 3);

INSERT INTO [Categories]([CategoryID],[Name])
VALUES ('BKS', 'Books'), ('MSC', 'Music'), ('HDW', 'Hardware'), ('STW', 'Software');

INSERT INTO [Products]([Name],[Price],[Category])
VALUES ('Harry Potter And The Sorcerers stone', 20.00, 'BKS'),
	   ('The Lone Eagle', 17.00, 'BKS'),
	   ('East Of Eden', 25.00, 'BKS'),
	   ('1989',  15.00, 'MSC'),
	   ('News of the World', 20.00, 'MSC'),
	   ('Greatest Hits: The Ultimate Collection', 34.00, 'MSC'),
	   ('Acer S240HL - Monitor', 500.00, 'HDW'),
	   ('Targus AMW57EU - Wireless Mouse', 22.00, 'HDW'),
	   ('Cannon Selphy CP910 - Photo printer', 170.00, 'HDW'),
	   ('Office Home And Business 2013 ENG T5D-01', 490.00, 'STW'),
	   ('Windows 7 Ultimate 32bit eng', 400.00, 'STW'),
	   ('DR Web Security Space', 9.00, 'STW');

SET IDENTITY_INSERT Customers ON

	INSERT INTO [Customers]([CustomerID], [Name], [Email], [Address], [Discount])
	VALUES (1 , 'Antoan Yordanov', 'antoanyordanov@gmail.com', 'Blvd Hristo Botev - 50A floor 7, ap.8', 2),
	       (2 , 'Aneta Krasimirova', 'anetak@gmail.com', 'Oreshaka str. - 54', 17.9),
		   (3 , 'Georgi Ivanov', 'georgiivanov@gmail.com', 'Blvd Dobri Chintulov - 17', 17),
	       (4 , 'Bobi Stefanov', 'bstefanov@gmail.com', 'Blvd Aleksandur Stamboliiski - 57', 14),
	       (5 , 'Kristina Todorova', 'kristinatodorova@gmail.com', 'Blvd Stefan Karadja - 2', 5);
SET IDENTITY_INSERT Customers OFF

INSERT INTO [Orders]([DateOfOrder], [Customer], [TotalPrice])
VALUES ('2017-01-15', 1, 15),
	   ('2017-01-29', 2, 27),
	   ('2017-02-14', 3, 20),
	   ('2017-02-17', 4, 8),
	   ('2017-03-20', 5, 21);