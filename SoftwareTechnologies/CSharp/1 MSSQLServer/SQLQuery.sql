SELECT * FROM BlogDB.dbo.Posts

SELECT Username, FullName 
FROM BlogDB.dbo.Users

SELECT * FROM BlogDB.dbo.Users
WHERE ID=2

SELECT * FROM BlogDB.dbo.Users
WHERE FullName >= 'M'

SELECT * FROM BlogDB.dbo.Users
ORDER BY Username

SELECT TOP 3 * FROM BlogDB.dbo.Users
ORDER BY FullName DESC


SELECT 
	p.ID AS PostID, p.Title, 
	c.ID AS CommentID, c.Text, c.Date
FROM BlogDB.dbo.Posts p
	JOIN BlogDB.dbo.Comments c ON p.ID = c.PostID

SELECT 
	c.ID as CommentID, c.Text AS CommentText,
	ISNULL(u.FullName, c.AuthorName) AS Author
FROM BlogDB.dbo.Comments c
	LEFT JOIN BlogDB.dbo.Users u ON c.AuthorID = u.ID
WHERE PostID = 1


SELECT 
	p.ID AS PostID, p.Title, 
	t.ID AS TagID, t.Name
FROM BlogDB.dbo.Posts p
	JOIN BlogDB.dbo.Posts_Tags pt ON p.ID = pt.PostID
	JOIN BlogDB.dbo.Tags t ON pt.TagID = t.ID

SELECT MIN(Date) FROM BlogDB.dbo.Posts


SELECT COUNT(*) AS [Comments Count]
FROM BlogDB.dbo.Comments WHERE PostID=1


SELECT PostID, COUNT(ID) AS CommentsCount
FROM BlogDB.dbo.Comments GROUP BY PostID


SELECT 
  DISTINCT p.ID as PostID, p.Title
FROM BlogDB.dbo.Posts p
  JOIN BlogDB.dbo.Posts_Tags pt ON p.ID = pt.PostID
WHERE pt.TagID IN
  (SELECT ID FROM BlogDB.dbo.Tags
   WHERE Name IN ('programming', 'Web'))
ORDER BY p.Title



INSERT INTO BlogDb.dbo.Posts(Title, Body, AuthorID)
VALUES('New Title', 'New post content', 3)

INSERT INTO BlogDB.dbo.Users(Username, PasswordHash) VALUES
  ('joe', HASHBYTES('SHA2_256', 'P@$$@123')),
  ('jeff', HASHBYTES('SHA2_256', 'SofiA!')),
  ('poly', HASHBYTES('SHA2_256', 'p@ss123'))



UPDATE BlogDB.dbo.Posts
SET Title = 'Title Updated!'
WHERE ID = 2;

UPDATE BlogDB.dbo.Posts
SET Date = '2016-05-29T23:51:00'
WHERE YEAR(date) = 2016;



DELETE FROM BlogDB.dbo.Posts WHERE ID=9;

DELETE FROM BlogDB.dbo.Comments 
WHERE AuthorID = (SELECT ID FROM BlogDB.dbo.Users 
					WHERE Username='maria');



USE master
GO
IF DB_ID('BlogDB') IS NOT NULL
BEGIN
  ALTER DATABASE BlogDB
  SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
  DROP DATABASE BlogDB
END
GO
