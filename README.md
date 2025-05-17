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
## 🔐 Authentication
JWT is used for securing API endpoints.

Users are assigned either a User or Admin role.

Database is seeded with default roles and an initial admin user during the first run.

## 📸 Screenshots
![image](https://github.com/user-attachments/assets/8865808a-da1f-4d4e-82d2-3b79e0a89853)
![image](https://github.com/user-attachments/assets/3f4e3c70-0e43-4d63-8487-9421a4a1b358)
![image](https://github.com/user-attachments/assets/0e7a1a80-ba91-42b6-a219-6496e91db371)
![image](https://github.com/user-attachments/assets/d5f055b0-0018-433f-803d-cc5d8f6356de)
![image](https://github.com/user-attachments/assets/86655e57-e443-4679-a354-712c593dfc29)
![image](https://github.com/user-attachments/assets/78718ee6-50d4-4500-9be2-dd06c1aa635a)
![image](https://github.com/user-attachments/assets/8ebbff49-8f53-4dcb-9c59-3391a02d69c3)


## 🧑‍💼 Author
Abdallah Taha

GitHub

Computer Science and Engineering, Mansoura University
