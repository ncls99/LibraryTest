CREATE TABLE Author (
	AuthorId INT PRIMARY KEY,
    AuthorName NVARCHAR(MAX)
);

CREATE TABLE Book (
    BookId INT PRIMARY KEY,
    Title NVARCHAR(MAX),
    FOREIGN KEY (AuthorId) REFERENCES Author(AuthorId)
);

INSERT INTO Author (Name) VALUES
('John Doe'),
('Jane Smith'),
('Michael Johnson')

INSERT INTO Book (Title, AuthorId) VALUES
('The Adventure Begins', 1),
('Mystery of the Lost Keys', 2),
('Coding 101', 3)