# 🧩 Dapper Demo

**Dapper Demo** is a simple and clean .NET 6 Web API project built to demonstrate how to perform CRUD operations using **Dapper**, a lightweight ORM for SQL Server.

---

## 🚀 Features

- ASP.NET Core Web API
- CRUD operations using Dapper
- Repository design pattern
- Dependency Injection setup
- Swagger UI for API testing
- SQL Server database integration

---

## 🛠️ Technologies Used

- **.NET 6**
- **Dapper**
- **SQL Server**
- **Swagger / Swashbuckle**
- **C#**

---
DapperDemo/
│
├── Controllers/
│ └── StudentsController.cs
│
├── Repositories/
│ └── StudentRepository.cs
│
├── Models/
│ └── Student.cs
│
├── appsettings.json
└── Program.cs

---

## ⚙️ Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/DapperDemo.git
Update the connection string in appsettings.json:
  "ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=DapperDemoDb;Trusted_Connection=True;"
  }
Run the project:
  dotnet run
Open Swagger UI in your browser:
  https://localhost:44325/swagger
  ---
📚 Example Endpoints
| Method | Endpoint             | Description                |
| ------ | -------------------- | -------------------------- |
| GET    | `/api/students`      | Get all students           |
| GET    | `/api/students/{id}` | Get a student by ID        |
| POST   | `/api/students`      | Create a new student       |
| PUT    | `/api/students`      | Update an existing student |
| DELETE | `/api/students/{id}` | Delete a student           |

## 🧠 About

This project was created as a demo for learning Dapper ORM in .NET applications, focusing on simplicity, performance, and clean architecture.

## 👨‍💻 Author

Youssef
Full Stack .NET Developer


## 📁 Project Structure

