# SimpleApp - ASP.NET Core MVC Testing Project

A simple ASP.NET Core MVC application built with .NET 9, adapted from Chapter 6 with additional modifications and comprehensive testing framework for student learning.

##  Overview

This project is a simple ASP.NET Core MVC web application that demonstrates fundamental concepts including:
- Model-View-Controller (MVC) pattern
- Product catalog display
- Unit testing with xUnit
- Modern .NET 9 features
- Test-driven development practices

The application displays a simple product catalog with kayak and lifejacket items, serving as a foundation for learning ASP.NET Core development and testing methodologies.

## Features

- **Product Display**: Simple product catalog showing name and price
- **MVC Architecture**: Clean separation of concerns using MVC pattern
- **Responsive Design**: Bootstrap-powered responsive UI
- **Unit Testing**: Comprehensive test suite using xUnit and Moq
- **Modern .NET**: Built with .NET 9 and latest ASP.NET Core features
- **Student-Friendly**: Designed for educational purposes with clear code structure

## 🛠 Technologies Used

- **Framework**: ASP.NET Core MVC (.NET 9)
- **Language**: C#
- **Testing**: xUnit, Moq, Microsoft.NET.Test.Sdk
- **UI**: Bootstrap, HTML5, CSS3, JavaScript
- **IDE**: Visual Studio / Visual Studio Code
- **Package Management**: NuGet

##  Prerequisites

Before running this application, ensure you have:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed
- Visual Studio Code
- Git (for version control)
- Web browser (Chrome, Firefox, Edge, Safari)

##  Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/samsur/SimpleApp.git Testing
cd Testing
```

### 2. Restore Dependencies

```bash
dotnet restore
```

### 3. Build the Solution

```bash
dotnet build
```

### 4. Run the Application

```bash
cd SimpleApp
dotnet run
```

The application will be available at `https://localhost:5001` or `http://localhost:5000`.

## 📁 Project Structure

```
Testing/
├── SimpleApp/                      # Main web application
│   ├── Controllers/
│   │   └── HomeController.cs       # Main controller handling requests
│   ├── Models/
│   │   ├── Product.cs              # Product model with sample data
│   │   └── ErrorViewModel.cs       # Error handling model
│   ├── Views/
│   │   ├── Home/
│   │   │   ├── Index.cshtml        # Product display view
│   │   │   └── Privacy.cshtml      # Privacy page
│   │   └── Shared/
│   │       ├── _Layout.cshtml      # Main layout template
│   │       └── Error.cshtml        # Error page
│   ├── wwwroot/                    # Static files (CSS, JS, images)
│   ├── Program.cs                  # Application entry point
│   └── SimpleApp.csproj            # Project configuration
├── SimpleApp.Tests/                # Unit test project
│   ├── UnitTest1.cs                # Sample unit tests
│   └── SimpleApp.Tests.csproj      # Test project configuration
├── Testing.sln                     # Solution file
└── README.md                       # This file
```

##  Running the Application

### Development Mode

```bash
cd SimpleApp
dotnet run
```

### Production Mode

```bash
cd SimpleApp
dotnet run --environment Production
```
## 🧪 Running Tests

### Run All Tests

```bash
dotnet test
```

### Test Categories

- **Unit Tests**: Test individual components in isolation
- **Integration Tests**: Test component interactions (planned)
- **Model Tests**: Validate model behavior and data
- **Controller Tests**: Test controller actions and responses

### .NET 9 Compatibility
- Updated to use .NET 9 SDK and runtime
- Modern C# language features and nullable reference types
- Updated package references and dependencies

### Enhanced Testing Framework
- **xUnit**: Modern testing framework with better .NET Core integration
- **Moq**: Mocking framework for dependency injection testing
- **Code Coverage**: Built-in coverage collection capabilities
- **Test Organization**: Structured test project with clear naming conventions

### Modern Development Practices
- **Implicit Usings**: Reduced boilerplate code
- **Nullable Reference Types**: Enhanced null safety
- **File-Scoped Namespaces**: Cleaner code organization
- **Top-Level Programs**: Simplified Program.cs structure

### Student Learning Enhancements
- Comprehensive comments and documentation
- Clear separation of concerns
- Example test cases for common scenarios
- README with learning objectives

## 🎯 Learning Objectives

By working with this project, students will learn:

1. **ASP.NET Core MVC Fundamentals**
   - Understanding the MVC pattern
   - Controller actions and routing
   - View rendering and data passing
   - Model binding and validation

2. **Unit Testing Best Practices**
   - Writing testable code
   - Using xUnit testing framework
   - Mocking dependencies with Moq
   - Test organization and naming conventions

3. **Modern .NET Development**
   - .NET 9 features and capabilities
   - Dependency injection patterns
   - Configuration management
   - Static asset handling

4. **Web Development Concepts**
   - HTTP request/response cycle
   - Client-server architecture
   - Responsive web design
   - State management

## 🧪 Testing Framework

### Test Structure

```csharp
[Fact]
public void ProductModel_ShouldHaveCorrectProperties()
{
    // Arrange
    var product = new Product { Name = "Test", Price = 100M };
    
    // Act & Assert
    Assert.Equal("Test", product.Name);
    Assert.Equal(100M, product.Price);
}
```

### Testing Best Practices Applied

- **AAA Pattern**: Arrange, Act, Assert
- **Descriptive Names**: Clear test method naming
- **Single Responsibility**: One concept per test
- **Isolation**: Tests don't depend on each other
- **Fast Execution**: Quick feedback loop

## Contributing

This is an educational project. Students and instructors are welcome to:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/your-feature`)
3. Commit changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Create a Pull Request

### Contribution Guidelines

- Follow existing code style and conventions
- Add tests for new functionality
- Update documentation as needed
- Ensure all tests pass before submitting


##  Additional Resources

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [xUnit Documentation](https://xunit.net/)
- [.NET 9 Documentation](https://docs.microsoft.com/en-us/dotnet/core/)
- [Moq Documentation](https://github.com/moq/moq4)

##  Tips for Students

1. **Start Small**: Understand each component before moving to complex features
2. **Test First**: Write tests before implementing features when possible
3. **Read Errors**: Pay attention to error messages and stack traces
4. **Debug Effectively**: Use breakpoints and step-through debugging
5. **Ask Questions**: Don't hesitate to seek help when stuck

