# ProductWebApp - ASP.NET Core Dapper CRUD Application

## 📌 Project Overview
This is a simple ASP.NET Core web application demonstrating basic **CRUD operations** using **Dapper** and **SQL Server**. It includes product listing, creation, editing, and deletion functionalities.

## 🚀 Technologies Used
- ASP.NET Core (8.0)
- Dapper (Micro ORM)
- SQL Server (MSSQL)
- Bootstrap 5 (for UI)
- jQuery + DataTables

## 📁 Project Structure
```
ProductWebApp/
│
├── Controllers/         # ProductController
├── Data/                # Repository interface and implementation
├── Models/              # Product model
├── Views/               # Razor views (Create, Edit, Delete, Index)
├── wwwroot/             # Static files
└── appsettings.json     # Configuration
```

## 🛠️ Setup Instructions

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/NwayOo88/ProductWebApp.git
cd ProductWebApp
```

### 2️⃣ Create the Database
- Open SQL Server Management Studio (SSMS) or your preferred SQL tool.
- Run the provided `schema.sql` script to create the database and tables.

**Important:**
- First, create the database manually:
```sql
CREATE DATABASE ProductDB;
GO
USE ProductDB;
```
- Then execute the provided `ProductDB_schema_data.sql` script.

### 3️⃣ Configure the Connection String
In `appsettings.json`, update the connection string as per your local setup:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ProductDB;Trusted_Connection=True;"
}
```

### 4️⃣ Run the Application
- Open the solution in **Visual Studio 2022**.
- Set `ProductWebApp` as the **Startup Project**.
- Press **F5** to run the application.


## ✅ Features

- 📃 **List Products** – View all products with price and creation date
- ➕ **Create Product** – Add new product to the database
- ✏️ **Edit Product** – Modify product name or price
- ❌ **Delete Product** – Remove a product from the database
- 💡 **UI Styling** – Responsive layout with Bootstrap and DataTables


## 📌 Page Navigation
- `/Product/Index` – Main page showing all products
- `/Product/Create` – Add new product
- `/Product/Edit/{id}` – Edit product by ID
- `/Product/Delete/{id}` – Delete confirmation

## 🧪 Validation
- Basic model validation using `ModelState.IsValid`
- Description field is optional

## 📬 Contact
If you have any questions, feel free to contact:
**nwayooswe.1004@gmail.com**

