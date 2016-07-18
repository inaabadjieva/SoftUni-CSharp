SELECT * FROM Blog.dbo.Posts

SELECT * FROM Blog.dbo.Users

SELECT title, body
FROM Blog.dbo.Posts

SELECT username, fullname
FROM Blog.dbo.Users
ORDER BY username ASC

SELECT username, fullname
FROM Blog.dbo.Users
ORDER BY fullname DESC, username DESC

SELECT * FROM Blog.dbo.Users
WHERE id in(SELECT AuthorId FROM Blog.dbo.Posts)

SELECT Blog.dbo.Users.UserName, Blog.dbo.Posts.Title 
FROM Blog.dbo.Users
JOIN Blog.dbo.Posts ON Blog.dbo.Users.Id = Blog.dbo.Posts.AuthorId 

SELECT UserName, FullName 
FROM Blog.dbo.Users
WHERE id in(SELECT AuthorId FROM Blog.dbo.Posts WHERE id=4)

SELECT UserName, FullName 
FROM Blog.dbo.Users
WHERE id in(SELECT AuthorId FROM Blog.dbo.Posts)
ORDER BY id DESC

INSERT INTO Blog.dbo.Posts(AuthorId, Title, Body, Date)
VALUES(2, 'Random Title', 'Random Content', CAST('2016-07-13T11:30:00' AS DateTime)) 

UPDATE Blog.dbo.Posts SET Title = 'New Title' WHERE Id=33

DELETE FROM Blog.dbo.Posts WHERE Id=33

SELECT COUNT(*) AS Posts_Count FROM Blog.dbo.Posts

SELECT COUNT(*) AS Posts_Count FROM Blog.dbo.Posts WHERE AuthorId=2

SELECT MIN(AuthorId) AS Min_Value FROM Blog.dbo.Posts

SELECT MIN(Date) AS Min_Value FROM Blog.dbo.Posts

SELECT MAX(AuthorId) AS Max_Value FROM Blog.dbo.Posts

SELECT MAX(Id) AS Max_Value FROM Blog.dbo.Tags

SELECT SUM(Id) AS Sum_Ids FROM Blog.dbo.Tags 

SELECT SUM(Id) AS Sum_Ids FROM Blog.dbo.Users
WHERE id in(SELECT AuthorId FROM Blog.dbo.Posts)

SELECT COUNT(DISTINCT (AuthorId)) FROM Blog.dbo.Posts 
	WHERE Date>'2016-06-14' AND Date<'2016-06-15'

SELECT * FROM Blog.dbo.Posts 
WHERE Date>'2016-06-14' AND Date<'2016-06-15'
ORDER BY AuthorId ASC

SELECT TOP 1 * FROM Blog.dbo.Posts 
WHERE AuthorId=2 ORDER BY Date ASC

SELECT * FROM Blog.dbo.Comments
ORDER BY AuthorName ASC, Id DESC  
