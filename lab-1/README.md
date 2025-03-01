# Warehouse Management System

## Principles Followed in the Code

### 1. DRY (Don't Repeat Yourself)
**Example:**
- The `Money` class encapsulates currency-related operations, preventing repetitive calculations in other classes.
- The `ShowInventory()` method in `Warehouse` prevents duplication of inventory display logic.

### 2. KISS (Keep It Simple, Stupid)
**Example:**
- The code avoids unnecessary complexity by structuring each class with clear and simple responsibilities.
- Each method has a well-defined purpose, avoiding excessive logic in a single place.

### 3. SOLID Principles
#### **S - Single Responsibility Principle (SRP)**
**Example:**
- `Money` handles only currency operations.
- `Product` manages product details and pricing.
- `Warehouse` handles inventory management.
- `Reporting` is responsible for report generation.

#### **O - Open/Closed Principle (OCP)**
**Example:**
- The `Money` class can be extended to support different currencies without modifying existing code.
- `Warehouse` can be extended to include new inventory operations.

#### **L - Liskov Substitution Principle (LSP)**
**Example:**
- If we introduced subclasses for `Product` (e.g., `PerishableProduct`), they could replace `Product` in `Warehouse` without breaking functionality.

#### **I - Interface Segregation Principle (ISP)**
**Example:**
- The code is structured to ensure interfaces are used effectively.
- `IMoney`, `IProduct`, `IWarehouse`, and `IReporting` provide clear separation of concerns.

#### **D - Dependency Inversion Principle (DIP)**
**Example:**
- `Reporting` depends on `IWarehouse` rather than a concrete `Warehouse` implementation, improving flexibility.

### 4. YAGNI (You Ain't Gonna Need It)
**Example:**
- The code implements only necessary features without adding premature optimizations.

### 5. Composition Over Inheritance
**Example:**
- Instead of using inheritance, the `Warehouse` class contains a list of `Product` objects.
- `Reporting` contains an `IWarehouse` instance instead of extending it.

### 6. Program to Interfaces, Not Implementations
**Example:**
- The design uses `IMoney`, `IProduct`, `IWarehouse`, and `IReporting` interfaces, ensuring flexibility for future changes.

### 7. Fail Fast Principle
**Example:**
- Encapsulation of money operations ensures invalid price reductions are handled appropriately.
- The `SetAmount` method in `Money` prevents negative values.


