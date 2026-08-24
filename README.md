# Online Clinic Booking API

Final Year Project - Clinic Appointment Booking System

## 1. Project Description
The Online Clinic Booking API is a RESTful backend system that allows patients to book appointments with doctors online. It solves double-booking, long queues, and manual paper systems.

Patients can register, login, view available doctors, and book appointments. Doctors availability is checked before booking to prevent conflicts.

## 2. Features
- JWT Authentication (Register / Login)
- Role Based Authorization (Doctor, Patient, Admin)
- Doctor Management - Add and View Doctors
- Appointment Booking with conflict checking
- View all appointments
- Swagger UI for testing
- Email Service placeholder

## 3. Tech Stack
- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server (localdb)
- JWT Bearer Authentication
- BCrypt for password hashing
- Swagger / OpenAPI

## 4. Project Structure

## 5. How to Run
1. Clone repo: `git clone https://github.com/YOUR_USERNAME/OnlineClinicBookingApi`
2. Open in Visual Studio 2022
3. Update connection string in appsettings.json
4. Run migrations:
