📚 Library Management System

A desktop Library Management System built with C# Windows Forms, ADO.NET, and SQL Server using the 3-Tier Architecture.

The system manages books, authors, categories, members, and borrowing/return operations.

🛠️ Technologies

- C#
- Windows Forms
- .NET Framework
- ADO.NET
- SQL Server
- 3-Tier Architecture
- Visual Studio

🏗️ Architecture

The project follows the 3-Tier Architecture:

- Presentation Layer – Windows Forms UI.
- Business Layer – Application logic and entities.
- Data Access Layer – SQL Server communication using ADO.NET.

✨ Features

📚 Books

- Add, update, delete, and view books.
- Assign books to authors and categories.
- Track book availability.

👤 Members

- Add, update, delete, and view members.

✍️ Authors & Categories

- Add, update, delete, and view authors and categories.

🔄 Borrowing & Returning

- Borrow books for members.
- Prevent borrowing unavailable books.
- Automatically update book availability.
- Return books and record the return date.
- Track borrowing status.

🗄️ Database

Main tables:

- Authors
- Categories
- Books
- Members
- Borrowings

The "Borrowings" table connects Books and Members using foreign keys.

📂 Project Structure

LibraryManagementSystem
│
├── Business
├── DataAccess
└── Forms

⚙️ How to Run

1. Open the solution in Visual Studio.
2. Create the required SQL Server database and tables.
3. Update the connection string in "clsDataAccessSettings".
4. Build and run the application.

🎯 Purpose

This project was built to practice OOP, 3-Tier Architecture, ADO.NET, SQL Server, CRUD operations, foreign keys, and Windows Forms development.

👨‍💻 Author

Mohammad

Built as a learning project while studying software development and database programming.
