Library Management System

Instructions to Run the Program :

->Ensure you have the .NET Core SDK installed on your system.

->Open the project in Visual Studio Code (VSCode) or your preferred C# development environment.

->Locate the LibraryManagementSystem.cs file and open it.

->In the VSCode terminal or your development environment's terminal, navigate to the directory containing the LibraryManagementSystem.cs file.

->Run the program by executing the following command: dotnet run This will start the Library Management System application and display the main menu.

Key Features and Enhancements

Basic Library Management System:

->The Book class represents a book with attributes like title, author, ISBN, and availability. ->The Library class manages a collection of Book objects, providing methods to add, remove, search, and list books. ->The BookFactory class is used to create either Book or EBook objects. ->Enhancing with OOP Principles and Inheritance:

->The EBook class is a subclass of the Book class, adding an additional attribute for file size. ->The LibraryManager class is responsible for handling user interactions and delegating library management tasks to the Library class, following the Single Responsibility Principle (SRP).

Applying SOLID Principles and Design Patterns:

->The LibraryManager class is implemented using the Singleton pattern, ensuring that only one instance of the class exists in the application. ->The BookFactory class follows the Factory pattern, allowing the creation of either Book or EBook objects without exposing the specific implementation details to the LibraryManager class.

SOLID Principles and Design Patterns:->

1)Single Responsibility Principle (SRP):

2)The Book, EBook, Library, and LibraryManager classes each have a single responsibility, making the code more modular and maintainable. Open/Closed Principle (OCP):

3)The code is designed to be open for extension but closed for modification. For example, adding a new type of book can be done by creating a new subclass of Book without modifying the existing classes. Liskov Substitution Principle (LSP):

4)The EBook class is a subclass of the Book class, and instances of EBook can be used wherever Book instances are expected, without breaking the application. Singleton Pattern:

5)The LibraryManager class is implemented using the Singleton pattern, ensuring that only one instance of the class exists in the application. This helps maintain the consistency and state of the library management system. Factory Pattern:

6)The BookFactory class follows the Factory pattern, allowing the creation of either Book or EBook objects without exposing the specific implementation details to the LibraryManager class. This promotes flexibility and extensibility in the future.