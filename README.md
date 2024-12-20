
# First.Cojali.Api

## Overview

This repository contains the **First.Cojali.Api**, a backend exercise designed to demonstrate proficiency in C#, .NET Core, and clean architectural principles. This project implements a REST API for managing user data, simulating real-world backend development scenarios.

### Repository URL
```
git@github.com:olonyl/First.Cojali.Api.git
```

### Context
This project was developed as part of a backend exercise for a job application. The exercise requirements include:

- **Technologies**: C#
- **Tasks**:
  1. Create a REST API with the following endpoints:
     - **GET**: Retrieve a list of users from a JSON file.
     - **POST**: Add a new user to the JSON file and simulate sending an email to the created user (no actual email is sent).
     - **PUT**: Update the data of an existing user.
  2. Provide a `README.md` file with instructions to execute the application.

### Evaluation Criteria
- Folder and file structure.
- Code readability.
- Use of **Domain-Driven Design (DDD)**.
- Implementation of **Hexagonal Architecture**.
- Adherence to **SOLID Principles**.

---

## Folder Structure

- **`.vs`**: Visual Studio project metadata.
- **`First.Cojali.Api`**: Main API implementation containing controllers, middleware, and configurations.
- **`First.Cojali.Api.Contracts`**: Interface definitions, DTOs, and contracts for communication between layers.
- **`First.Cojali.Api.IoC`**: Dependency injection and service registration.
- **`First.Cojali.Api.sln`**: Solution file for Visual Studio.
- **`First.Cojali.Application`**: Contains application-level services and business logic.
- **`First.Cojali.Domain`**: Core entities, value objects, and business rules.
- **`First.Cojali.Infrastructure`**: Data access, persistence logic, and integrations.

---

## Setup Instructions

### Prerequisites
1. **.NET SDK**: Download the latest .NET SDK from [Microsoft](https://dotnet.microsoft.com/).
2. **Visual Studio**: Use Visual Studio or another IDE that supports .NET Core.
3. **JSON Data File**: Ensure the JSON file for user data is available in the correct location (see details below).

---

### Configuring `appsettings.json`

The API relies on a `UserJsonFilePath` property in `appsettings.json` or `appsettings.Development.json` to locate the JSON file for storing user data. This property is combined with the application's base directory using the following logic:

```csharp
var absolutePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));
```

Where `relativePath` is the value of `UserJsonFilePath` in the configuration.

#### Default Example
With the default configuration:
```json
"DataSources": {
  "UserJsonFilePath": "..\\..\\..\\..\\First.Cojali.Infrastructure\\Data\\users.json"
}
```
If the project structure is as follows:
```
C:\project\Cojali\
├── First.Cojali.Api\
├── First.Cojali.Infrastructure\
│   └── Data\
│       └── users.json
```
The computed absolute path would be:
```
C:\project\Cojali\First.Cojali.Infrastructure\Data\users.json
```

#### Customizing the JSON File Location or Name
If you want to place the JSON file in a different location or name it differently:
1. Update the `UserJsonFilePath` property in `appsettings.json`:
   ```json
   "DataSources": {
     "UserJsonFilePath": "path\\to\\your\\custom_users.json"
   }
   ```
2. For example:
   - File Location: `C:\data\my_users.json`
   - Configuration:
     ```json
     "DataSources": {
       "UserJsonFilePath": "..\\..\\..\\..\\data\\my_users.json"
     }
     ```

---

### Steps to Run
1. Clone the repository:
   ```bash
   git clone git@github.com:olonyl/First.Cojali.Api.git
   ```
2. Open the solution in Visual Studio:
   ```bash
   cd First.Cojali.Api
   start First.Cojali.Api.sln
   ```
3. Restore NuGet dependencies:
   ```bash
   dotnet restore
   ```
4. Ensure `appsettings.json` or `appsettings.Development.json` has the correct `UserJsonFilePath`.
5. Run the project:
   ```bash
   dotnet run --project First.Cojali.Api
   ```

---

## Usage

### Endpoints
- **GET /users**: Retrieves a list of users from the JSON file.
- **POST /users**: Adds a new user to the JSON file and simulates sending an email.
- **PUT /users/{id}**: Updates the information of an existing user.

### API Testing
Use [Postman](https://www.postman.com/) or Swagger (if implemented) to test the API endpoints. If Swagger is enabled, documentation can be accessed at:
```
http://localhost:[port]/swagger
```

---

## Contribution Guidelines

1. **Branch Naming**: Use feature-specific branches (e.g., `feature/add-user-endpoint`).
2. **Code Standards**: Adhere to clean code principles and SOLID practices.
3. **Tests**: Write unit tests for any new features or bug fixes.
4. **Pull Requests**: Provide a clear and descriptive summary of changes in PRs.

---

## License
This project is licensed under the MIT License.

## Acknowledgments
- Developed as part of a technical exercise.
- Inspired by best practices in backend architecture and design patterns.