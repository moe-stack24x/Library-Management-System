📚 Library Management System

A desktop Library Management System built with C# Windows Forms, ADO.NET, and SQL Server following the 3-Tier Architecture pattern.

The system is designed to manage books, authors, categories, library members, and borrowing/return operations.

🛠️ Technologies Used

- C#
- Windows Forms
- .NET Framework
- ADO.NET
- SQL Server
- Visual Studio
- 3-Tier Architecture

🏗️ Architecture

The project follows the 3-Tier Architecture:

1. Presentation Layer

Responsible for the Windows Forms user interface and user interactions.

Includes forms such as:

- Authors
- Categories
- Books
- Members
- Borrowings

2. Business Layer

Contains the application's business logic and represents the main entities.

Examples:

- "clsAuthor"
- "clsCategory"
- "clsBook"
- "clsMember"
- "clsBorrowing"

3. Data Access Layer

Responsible for communicating with the SQL Server database using ADO.NET.

Examples:

- "clsAuthorsData"
- "clsCategoriesData"
- "clsBooksData"
- "clsMembersData"
- "clsBorrowingsData"

✨ Features

👤 Members

- Add members
- Update member information
- Delete members
- View all members

📚 Books

- Add books
- Update books
- Delete books
- Assign books to authors and categories
- Track book availability

✍️ Authors

- Add authors
- Update authors
- Delete authors
- View authors

🏷️ Categories

- Add categories
- Update categories
- Delete categories
- View categories

🔄 Borrowing & Returning

- Borrow a book for a selected member
- Prevent borrowing a book that is already borrowed
- Automatically mark a borrowed book as unavailable
- Return a borrowed book
- Automatically record the return date
- Automatically mark the returned book as available
- Track borrowing status

🗄️ Database

The system uses SQL Server with the following main tables:

- "Authors"
- "Categories"
- "Books"
- "Members"
- "Borrowings"

The "Borrowings" table connects books and members using foreign keys.

🔗 Relationships

- One Author can have multiple Books.
- One Category can contain multiple Books.
- One Member can have multiple Borrowings.
- One Book can have multiple borrowing records over time.

📂 Project Structure

LibraryManagementSystem
│
├── Business
│   ├── clsAuthor.cs
│   ├── clsBook.cs
│   ├── clsCategory.cs
│   ├── clsMember.cs
│   └── clsBorrowing.cs
│
├── DataAccess
│   ├── clsDataAccessSettings.cs
│   ├── clsAuthorsData.cs
│   ├── clsBooksData.cs
│   ├── clsCategoriesData.cs
│   ├── clsMembersData.cs
│   └── clsBorrowingsData.cs
│
└── Forms
    ├── frmAuthors.cs
    ├── frmCategories.cs
    ├── frmBooks.cs
    ├── frmMembers.cs
    └── frmBorrowings.cs

⚙️ How to Run

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Create the required database and tables in SQL Server.
4. Update the database connection string in "clsDataAccessSettings".
5. Build the solution.
6. Run the application.

🎯 Purpose

This project was developed to practice and demonstrate:

- Object-Oriented Programming
- 3-Tier Architecture
- ADO.NET
- SQL Server database operations
- CRUD operations
- Foreign key relationships
- Windows Forms development
- Basic library borrowing and returning logic

👨‍💻 Author

Mohammad

Built as a learning project while studying software development and database programming.
