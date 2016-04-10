SELECT FirstName FROM Person.Person;

--

SELECT	FirstName,LastName,[address].City
FROM Person.Person p
INNER JOIN Person.BusinessEntityAddress entity
ON p.BusinessEntityID = entity.BusinessEntityID 
INNER JOIN Person.[Address] [address]
ON entity.AddressID = [address].AddressId
WHERE [address].City != 'Payson'

--

SELECT * FROM Person.Person p 
WHERE p.Age > 40;

--

SELECT  FirstName,LastName
FROM Person.Person p 
WHERE p.LastName LIKE '%ay';

--

SELECT  FirstName,LastName
FROM Person.Person p 
WHERE p.LastName = 'Mary';

-- 

SELECT  FirstName,LastName
FROM Person.Person p 
WHERE p.LastName Like '%Mary%';

--

UPDATE Person.Person
SET LastName = 'Weber-Williams'
WHERE FirstName = 'Jonie' 
	AND LastName = 'Weber'

--

UPDATE Person.Person
SET Age = Age + 1
WHERE FirstName = 'Dirk' 
	AND	LastName = 'Smith'

--

UPDATE Person.Person
SET Title = 'Administrative Assistant'
WHERE Title = 'Assistant'

--

UPDATE Person.Person
SET Salary = Salary + 3500
WHERE Salary < 30000

--

UPDATE Person.Person
SET Salary = Salary + 4500
WHERE Salary < 33500

--

UPDATE Person.Person
SET Title = 'Programmer III'
WHERE Title = 'Programmer II'

--

UPDATE Person.Person
SET Title = 'Programmer II'
WHERE Title = 'Programmer'