# E-Commerce

## Overview

This project is a comprehensive, full-stack E-Commerce platform developed using ASP.NET Core Web API for the backend and Angular for the frontend. The solution is designed to demonstrate modern software architecture, best practices, and a wide range of e-commerce features, making it suitable both as a learning resource and as a foundation for real-world applications.

The backend leverages the power of ASP.NET Core, Entity Framework Core, and PostgreSQL to provide a robust, scalable, and secure API. The frontend, built with Angular and Angular Material, offers a responsive and user-friendly interface for both customers and administrators.

---

## Features

### User & Authentication

- **User Registration & Login:** Secure registration and login system using ASP.NET Core Identity and JWT-based authentication.
- **Role Management:** Assign and manage roles (e.g., Admin, User) with fine-grained access control.
- **Password Reset:** Users can request password reset links via email, ensuring account security.
- **Profile Management:** Users can update their personal information and change passwords.

### Product Management

- **CRUD Operations:** Administrators can create, update, delete, and view products.
- **Stock Management:** Real-time stock updates, including QR code-based stock entry for efficient warehouse operations.
- **Product Images:** Upload and manage multiple images per product.
- **Category Management:** Organize products into categories for easier browsing.

### Basket & Order Management

- **Shopping Basket:** Users can add, update, or remove products from their basket.
- **Order Placement:** Seamless order creation from the basket, with order summary and confirmation.
- **Order Tracking:** Users and admins can view order history and details.
- **Order Completion:** Admins can mark orders as completed, triggering email notifications to customers.

### File & Invoice Management

- **File Uploads:** Securely upload and manage files such as product images and invoices.
- **Invoice Generation:** Generate and send invoices to customers upon order completion.

### Admin Panel

- **User Management:** View, edit, and manage all users and their roles.
- **Role & Permission Management:** Assign roles to users and define endpoint/menu-based permissions.
- **Product & Order Management:** Full control over products, orders, and stock.
- **Menu Management:** Dynamically manage application menus and their associated permissions.

### Notifications & Logging

- **Email Notifications:** Automated emails for password resets, order confirmations, and completions.
- **Real-Time Notifications:** (Optional) Use SignalR for instant updates to users/admins.
- **Centralized Logging:** All critical actions are logged using Serilog, with logs stored in PostgreSQL and/or Seq for monitoring and auditing.

### Security

- **JWT Authentication:** Secure API endpoints with token-based authentication.
- **Role-Based Authorization:** Restrict access to sensitive operations based on user roles.
- **Input Validation:** All user inputs are validated using FluentValidation to prevent invalid data and attacks.

### API Documentation

- **Swagger/OpenAPI:** Interactive API documentation for easy testing and integration (if enabled).

---

## Project Structure

```
.
├── ECommerceAPI/                # Backend solution (ASP.NET Core)
│   ├── Core/                    # Domain entities, interfaces, application logic
│   ├── Infrastructure/          # Data access, external services, migrations
│   ├── Presentation/            # API controllers, filters, startup
│   └── ECommerceAPI.sln         # Solution file
├── ECommerceClient/             # Frontend (Angular)
│   ├── src/                     # Angular source code
│   ├── angular.json             # Angular CLI config
│   └── package.json             # NPM dependencies
├── .github/                     # GitHub workflows (CI/CD)
├── .gitignore                   # Git ignore rules
├── .gitattributes               # Git attributes
└── README.md                    # Project documentation
```

---

## Backend (ASP.NET Core API)

The backend is structured using Clean Architecture principles, separating concerns into Domain, Application, Infrastructure, and Presentation layers. This ensures maintainability, testability, and scalability.

- **Domain Layer:** Contains core business entities and interfaces.
- **Application Layer:** Implements business logic, use cases, and DTOs.
- **Infrastructure Layer:** Handles data persistence (EF Core), external services (email, file storage), and migrations.
- **Presentation Layer:** Exposes RESTful API endpoints, handles authentication, authorization, and request validation.

**Key Technologies:**
- ASP.NET Core 7+
- Entity Framework Core (PostgreSQL)
- ASP.NET Core Identity
- MediatR (CQRS pattern)
- Serilog (logging)
- FluentValidation (input validation)
- SignalR (optional, for real-time features)

---

## Frontend (Angular)

The frontend is a modern, single-page application built with Angular and Angular Material, providing a seamless user experience for both customers and administrators.

- **Authentication:** JWT-based, with guards for protected routes.
- **State Management:** RxJS and Angular services.
- **UI Components:** Angular Material for consistent, responsive design.
- **Admin Dashboard:** Manage users, roles, products, orders, and menus.
- **Dialogs & Notifications:** User-friendly modals and toast notifications for feedback.

---

## Database & Migrations

- **Database:** PostgreSQL
- **Migrations:** Managed with Entity Framework Core, ensuring database schema is always in sync with the codebase.
- **Entities:** Users, Roles, Products, Orders, Baskets, Files, Menus, Endpoints, etc.
- **Relationships:** All relationships are defined with proper foreign keys and navigation properties for data integrity.

---

## Authentication & Authorization

- **Identity:** ASP.NET Core Identity for user and role management.
- **JWT:** Secure token-based authentication for all API endpoints.
- **Role Management:** Assign roles to users and restrict access to endpoints and menus accordingly.
- **Password Reset:** Secure, token-based password reset flow with email notifications.

---

## How to Run

### Prerequisites

- [.NET 7 SDK or later](https://dotnet.microsoft.com/download)
- [Node.js & NPM](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [PostgreSQL](https://www.postgresql.org/)

### Backend

1. Configure your PostgreSQL connection string in `appsettings.json`.
2. Apply database migrations:
    ```sh
    dotnet ef database update
    ```
3. Run the API:
    ```sh
    dotnet run --project ECommerceAPI/Presentation/ECommerceAPI.API
    ```

### Frontend

1. Install dependencies:
    ```sh
    cd ECommerceClient
    npm install
    ```
2. Run the Angular app:
    ```sh
    ng serve
    ```
3. Open [http://localhost:4200](http://localhost:4200) in your browser.

---

## Development & Contribution

- **Code Style:** Follows industry-standard .NET and Angular best practices.
- **Testing:** Unit and integration tests can be run with `ng test` (Angular) and `dotnet test` (API).
- **CI/CD:** GitHub Actions workflows for automated build and test.
- **Contributions:** Pull requests are welcome! Please open an issue to discuss major changes before submitting.

---

## License

This project has been developed with the training series "Asp.NET Core 6 + Angular | Mini E-Commerce Application Series" on Gençay Yıldız's YouTube channel and its license belongs to Gençay Yıldız. Some feature and bug improvements have been made by me.

---

## Acknowledgements

- [ASP.NET Core](https://docs.microsoft.com/aspnet/core)
- [Angular](https://angular.io/)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [Serilog](https://serilog.net/)
- [PostgreSQL](https://www.postgresql.org/)
- [Angular Material](https://material.angular.io/)

---

## Contact

For questions or support, please open an issue on GitHub.
