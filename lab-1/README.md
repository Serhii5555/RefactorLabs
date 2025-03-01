# Principles Followed in the Code

This project references to several programming principles to ensure maintainability, readability, and efficiency. Below is an analysis of how each principle is followed, with references to relevant files and lines of code.

## 1. DRY (Don't Repeat Yourself)
The code avoids redundancy by encapsulating reusable logic into classes and methods. For example:
- The `Money` class is used for price representation in multiple classes instead of repeating money-related logic.
- `SetValue` in `Money` allows setting both the whole part and cents, preventing redundant assignments.
  
**Reference:** [Money.cs](./ConsoleApp/Classes/Money.cs), lines 8-22

## 2. KISS (Keep It Simple, Stupid)
The code is structured simply and avoids unnecessary complexity:
- Interfaces like `IMoney`, `IProduct`, `IWarehouse`, and `IReporting` keep responsibilities clear.
- Each class has a single, well-defined responsibility.
  
**Reference:** [Money.cs](./ConsoleApp/Classes/Money.cs), [Product.cs](./ConsoleApp/Classes/Product.cs), [Warehouse.cs](./ConsoleApp/Classes/Warehouse.cs), [Reporting.cs](./ConsoleApp/Classes/Reporting.cs)

## 3. SOLID Principles

### 3.1 Single Responsibility Principle (SRP)
Each class is responsible for a single aspect:
- `Money` handles currency values.
- `Product` represents a product and its price.
- `Warehouse` stores information about stock.
- `Reporting` manages inventory-related reports.
  
**Reference:** All class files.

### 3.2 Open/Closed Principle (OCP)
The code allows extension without modification:
- New types of products or reports can be introduced without modifying existing classes.
- The `Money` class could be extended with different currencies without altering its core logic.
  
**Reference:** [Money.cs](./ConsoleApp/Classes/Money.cs), [Product.cs](./ConsoleApp/Classes/Product.cs)

### 3.3 Liskov Substitution Principle (LSP)
All implementations respect their interfaces and can be substituted without breaking the code:
- `Product`, `Warehouse`, and `Reporting` classes implement their respective interfaces correctly.
  
**Reference:** [Product.cs](./ConsoleApp/Classes/Product.cs), [Warehouse.cs](./ConsoleApp/Classes/Warehouse.cs), [Reporting.cs](./ConsoleApp/Classes/Reporting.cs)

### 3.4 Interface Segregation Principle (ISP)
Interfaces are designed to be specific and not force unused methods:
- `IMoney` contains only money-related methods.
- `IProduct` defines only price-reducing functionality.
- `IReporting` handles only reporting.
  
**Reference:** [Interfaces in each file](./ConsoleApp/Interfaces)

### 3.5 Dependency Inversion Principle (DIP)
High-level modules depend on abstractions, not concrete implementations:
- Classes interact through interfaces rather than concrete classes.
  
## 4. YAGNI (You Ain't Gonna Need It)
The project includes only necessary functionality:
- No extra features are implemented beyond requirements.
- Methods and properties serve direct purposes without unnecessary complexity.
  
## 5. Composition Over Inheritance
Instead of deep inheritance hierarchies, the code uses composition:
- `Product` contains a `Money` object instead of extending it.
- `Warehouse` contains `Money` for price representation instead of inheritance.
  
**Reference:** [Product.cs](./ConsoleApp/Classes/Product.cs), [Warehouse.cs](./ConsoleApp/Classes/Warehouse.cs)

## 6. Program to Interfaces, Not Implementations
The system relies on interfaces rather than concrete classes:
- `IProduct`, `IMoney`, `IWarehouse`, and `IReporting` define expected behaviors.
- Concrete classes implement these interfaces without tight coupling.
  
## 7. Fail Fast
The code checks conditions early to prevent errors:
- The `ReducePrice` method ensures prices do not go negative.
- `RegisterShipment` verifies stock before reducing it.
  
**Reference:** [Product.cs](./ConsoleApp/Classes/Product.cs), [Reporting.cs](./ConsoleApp/Classes/Reporting.cs)
