📚 Library Management System

A C# Windows Forms Library Management Application built following the 3-Tier Architecture pattern and utilizing ADO.NET for SQL Server database operations.

---

🏗️ Architecture Overview

This project follows the 3-Tier Software Architecture to ensure separation of concerns, maintainability, and scalability.

🖥️ Presentation Layer

"LibraryManagementSystem"

Windows Forms UI responsible for:

- User interactions
- Form validation
- Data visualization
- Managing application forms

🧠 Business Logic Layer

"LibraryManagementSystem.Business"

Responsible for:

- Business rules
- Entity management
- Processing application logic
- Connecting the Presentation Layer with the Data Access Layer

🗄️ Data Access Layer

"LibraryManagementSystem.DataAccess"

Responsible for database operations using ADO.NET:

- "SqlConnection"
- "SqlCommand"
- "SqlDataReader"
- "DataTable"

---

✨ Features

📚 Books

- ➕ Add books
- ✏️ Edit books
- 🗑️ Delete books
- 🔗 Assign books to authors and categories
- 📊 Track book availability

👤 Members

- ➕ Add members
- ✏️ Edit members
- 🗑️ Delete members
- 👀 View members

✍️ Authors & Categories

- ➕ Add authors and categories
- ✏️ Edit authors and categories
- 🗑️ Delete authors and categories

🔄 Borrowing & Returning

- 📖 Borrow books for members
- 🚫 Prevent borrowing unavailable books
- 🔴 Automatically mark borrowed books as unavailable
- 🔄 Return borrowed books
- 📅 Automatically record the return date
- 🟢 Automatically mark returned books as available
- 📊 Track borrowing status

---

🗄️ Database

The application uses Microsoft SQL Server with the following main tables:

- "Authors"
- "Categories"
- "Books"
- "Members"
- "Borrowings"

The "Borrowings" table connects books and members using foreign key relationships.

---

🔗 Relationships

- One Author → Many Books
- One Category → Many Books
- One Member → Many Borrowings
- One Book → Many Borrowing Records

---
## 🛠️ Tech Stack

| Technology | Usage |
|------------|-------|
| C# | Application development |
| .NET Framework | Application framework |
| Windows Forms | Graphical User Interface |
| ADO.NET | Database access |
| Microsoft SQL Server | Database |
| Visual Studio | Development Environment |
| 3-Tier Architecture | Application architecture |
---

🚀 Getting Started

1. Clone the Repository

git clone <your-repository-url>

2. Open the Project

Open the solution in Visual Studio.

3. Configure the Database

Create the required SQL Server database and tables, then update the connection string in:

"clsDataAccessSettings"

4. Run the Application

Build and run the project.

---

🎯 Purpose

This project was developed to practice and demonstrate:

- Object-Oriented Programming
- 3-Tier Architecture
- ADO.NET
- SQL Server database operations
- CRUD operations
- Foreign key relationships
- Windows Forms development
- Library borrowing and returning logic

---

👨‍💻 Author

Mohammad

Built as a learning project while studying   Curse number 18 {C# & DataBase Connectivity(ADO.NET)} in ProgrammingAdvices RoadMap.
