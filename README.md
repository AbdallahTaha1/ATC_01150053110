# 🎉 EMS - Event Management System

**EMS (Evento)** is a full-stack Event Management System built with ASP.NET Core and Angular. It allows users to explore, book, and manage events, while providing admins with full control over event creation and management.

## 🔧 Technologies Used

### Backend
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**
- **MediatR** – for CQRS and clean command/query separation
- **Repository Pattern** & **Unit of Work**
- **ASP.NET Identity** – user authentication & role management
- **JWT Authentication**
- **Clean Architecture**

### Frontend
- **Angular**
- **Bootstrap** – responsive design

---

## 🧑‍💻 Features

### 👤 User
- Register & login with JWT authentication
- View all available events
- Book an event (only after logging in)
- View full history of their event bookings

### 🛠️ Admin
- Login as an admin
- View all events
- Create new events
- Edit or delete existing events

---

## 🗂️ Project Structure
```
### Backend
EMS.API/
├── Application/ # Application layer (CQRS handlers, DTOs, services)
├── Domain/ # Domain entities and enums
├── Infrastructure/ # Data access, repositories, EF Core configurations
├── Persistence/ # DbContext and migrations
├── API/ # Controllers and middlewares
```

### Frontend
```
ems-angular/
├── src/
│ ├── app/
│ │ ├── components/
│ │ ├── services/
│ │ ├── models/
│ │ ├── auth/
│ │ ├── admin/
│ │ └── user/
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 7 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)

### Backend Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/AbdallahTaha1/EMS.git
  Navigate to the API folder:


    cd EMS.API
Update connection string in appsettings.json.

    Run database migrations:


    dotnet ef database update
Run the backend:


    dotnet run
Frontend Setup
Navigate to the Angular project:

    cd ems-angular
Install dependencies:

    npm install
Run the frontend:

    ng serve
🔐 Authentication
JWT is used for securing API endpoints.

Users are assigned either a User or Admin role.

Database is seeded with default roles and an initial admin user during the first run.

📸 Screenshots
(Add screenshots of UI if available)

🧑‍💼 Author
Abdallah Taha

GitHub

Computer Science and Engineering, Mansoura University
