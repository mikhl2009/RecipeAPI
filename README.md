Absolutely, here's an English version of a comprehensive README for your RecipeAPI project to include on GitHub:

---

# RecipeAPI

## Project Overview
RecipeAPI is a RESTful web service designed to manage a recipe database interactively. It allows users to register, log in, manage their recipes, categorize them, and rate recipes posted by others. Built using ASP.NET Core, this project leverages the Entity Framework for ORM and SQL Server for data persistence.

## Features
- **User Authentication and Authorization**: Secure user registration and login process using JWT (JSON Web Tokens).
- **Recipe Management**: Users can add, update, delete, and retrieve recipes. Each recipe is linked to the user account that created it, ensuring that users can only modify their entries.
- **Category Management**: Recipes can be categorized. Categories are dynamic and can be added and modified by users.
- **Rating System**: Users can rate recipes on a scale from 1 to 5, which allows for community feedback on recipes.
- **Search Functionality**: Recipes can be searched by title.
- **API Documentation**: Comprehensive API documentation using Swagger UI.

## Technologies Used
- **ASP.NET Core 5.0**: For creating the web API.
- **Entity Framework Core**: For database integration and management.
- **SQL Server**: As the backend database.
- **JWT Authentication**: For securing the API and managing user sessions.
- **Swagger**: For API documentation and testing interface.

## Getting Started

### Prerequisites
- .NET 5.0 SDK
- SQL Server
- Visual Studio or any compatible IDE that supports .NET development

### Installation
1. **Clone the repository**
   ```bash
   git clone https://github.com/SimonLof/RecipeAPI.git
   ```
2. **Navigate to the project directory**
   ```bash
   cd RecipeAPI
   ```
3. **Restore dependencies**
   ```bash
   dotnet restore
   ```
4. **Setup the database**
   - Make sure SQL Server is running.
   - Update the connection string in `appsettings.json`.
   - Apply migrations:
     ```bash
     dotnet ef database update
     ```

5. **Run the application**
   ```bash
   dotnet run
   ```

### Using the API
- Navigate to `http://localhost:5121/swagger` to view the Swagger UI where you can test the API endpoints.

## How to Contribute
1. **Fork the repository**
2. **Create a new branch for your feature**
   ```bash
   git checkout -b feature/YourFeatureName
   ```
3. **Make your changes and commit them**
   ```bash
   git commit -am 'Add some feature'
   ```
4. **Push to the branch**
   ```bash
   git push origin feature/YourFeatureName
   ```
5. **Create a new Pull Request**

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details.
