# Documentation: Polymorphism.cs

## Overview
The `Polymorphism.cs` file demonstrates the **Polymorphism** principle from GRASP (General Responsibility Assignment Software Patterns). Polymorphism allows behavior to vary based on the type of object, enabling dynamic method dispatch. This principle helps eliminate conditional logic, making the system more flexible, maintainable, and extensible.

This file provides examples of both failed and successful implementations of polymorphism, focusing on how it simplifies the borrowing logic for different types of books.

---

## Workflow Without Polymorphism

### **BorrowService**
The `BorrowService` class demonstrates a failed implementation of polymorphism. It uses conditional logic to handle different types of books (`Fiction` and `NonFiction`).

#### Workflow:
1. The `Borrow` method receives a `Book` object.
2. It checks the `Type` property of the book (e.g., `"Fiction"` or `"NonFiction"`).
3. Based on the type, it applies specific logic for borrowing.

#### Issues:
- **Tight Coupling**: The `BorrowService` class is tightly coupled to the `Book` class and its `Type` property.
- **Violation of Open/Closed Principle**: Adding a new book type requires modifying the `Borrow` method, making the class harder to extend.
- **Low Maintainability**: The conditional logic becomes harder to manage as the number of book types increases.

---

## Workflow With Polymorphism

### **OurBook and Subclasses**
The `OurBook` class is an abstract base class that defines a common interface for all book types. Subclasses like `Fiction` and `NonFiction` implement specific behavior.

#### Workflow:
1. Each book type (e.g., `Fiction`, `NonFiction`) overrides the `GetMaxBarrowDays` method to define its own borrowing rules.
2. The `SafeBorrowService` class interacts with the `OurBook` abstraction, relying on polymorphism to handle different book types dynamically.

### **SafeBorrowService**
The `SafeBorrowService` class demonstrates a successful implementation of polymorphism. It delegates the borrowing logic to the `OurBook` abstraction.

#### Workflow:
1. The `Borrow` method receives an `OurBook` object.
2. It calls the `GetMaxBarrowDays` method on the book object.
3. The specific implementation of `GetMaxBarrowDays` is determined at runtime based on the book's type (e.g., `Fiction`, `NonFiction`).

---

## Benefits of Using Polymorphism

### **1. Flexibility**
- The `SafeBorrowService` class can handle any type of book that extends `OurBook`, without requiring changes to its code.
- New book types can be added by creating new subclasses of `OurBook`.

### **2. Maintainability**
- The borrowing logic for each book type is encapsulated within its respective class, making the code easier to understand and maintain.
- Eliminates the need for complex conditional logic.

### **3. Adherence to Open/Closed Principle**
- The `SafeBorrowService` class is open for extension (new book types) but closed for modification (no changes required for new types).

### **4. Reusability**
- The `OurBook` abstraction and its subclasses can be reused in other parts of the system, promoting code reuse.

---

## Comparison: Without vs. With Polymorphism

| Aspect                  | Without Polymorphism (BorrowService) | With Polymorphism (SafeBorrowService) |
|-------------------------|---------------------------------------|---------------------------------------|
| **Coupling**            | Tightly coupled to `Book` and its `Type` property. | Loosely coupled to the `OurBook` abstraction. |
| **Maintainability**     | Hard to maintain as the number of book types increases. | Easy to maintain; each book type manages its own logic. |
| **Extensibility**       | Requires modifying the `Borrow` method for new book types. | New book types can be added without modifying existing code. |
| **Code Complexity**     | Relies on conditional logic, which can grow unwieldy. | Eliminates conditional logic through dynamic dispatch. |

---

## Conclusion
The `Polymorphism.cs` file effectively demonstrates the benefits of using polymorphism to simplify and improve the borrowing logic for different book types. By relying on the `OurBook` abstraction and its subclasses, the system achieves flexibility, maintainability, and adherence to GRASP principles. This design approach ensures that the system is robust, extensible, and easy to manage.
