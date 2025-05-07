# Documentation: Coupling.cs

## Overview
The `Coupling.cs` file demonstrates the concept of **Low Coupling**, a key principle in GRASP (General Responsibility Assignment Software Patterns). Low coupling ensures that classes and components in a system are minimally dependent on each other, improving modularity, maintainability, and flexibility.

---

## Classes and Interfaces in `Coupling.cs`

### **1. Coupling**
The `Coupling` class is currently a placeholder and does not contain any functionality. It may serve as a conceptual or structural component in the system, potentially to be extended in the future.

---

### **2. ISearchable (Interface)**
The `ISearchable` interface defines an abstraction for searchable items. It ensures that any class implementing this interface provides the following:
- A `Name` property.
- An `IsAvailable()` method to determine availability.

#### Purpose:
- Promotes **Low Coupling** by allowing the `Search` class to depend on the abstraction (`ISearchable`) rather than a specific implementation (e.g., `MyBook`).

---

### **3. MyBook**
The `MyBook` class implements the `ISearchable` interface and represents a concrete implementation of a searchable item.

#### Key Properties and Methods:
- **`Name`**: Represents the name of the book.
- **`IsBarrow`**: Indicates whether the book is borrowed.
- **`IsAvailable()`**: Implements the `ISearchable` interface method to determine if the book is available.

---

### **4. Search**
The `Search` class demonstrates **Low Coupling** by depending only on the `ISearchable` interface rather than a specific implementation like `MyBook`.

#### Key Method:
- **`SearchBook(ISearchable item)`**:
  - Accepts any object implementing the `ISearchable` interface.
  - Checks the availability of the item using the `IsAvailable()` method.
  - Outputs whether the item is available or not.

## GRASP Principle: Low Coupling
The **Low Coupling** principle is applied in the `Search` class. By depending on the `ISearchable` interface instead of a specific class like `MyBook`, the design achieves:

    1. **Flexibility**: The `Search` class can work with any class implementing the `ISearchable` interface, not just `MyBook`.
    2. **Maintainability**: Changes to the `MyBook` class or other implementations of `ISearchable` do not affect the `Search` class.
    3. **Reusability**: The `Search` class can be reused in different contexts with different implementations of `ISearchable`.

---

## Use Case
The `Coupling.cs` file can be used in a library management system to:
- Define searchable items using the `ISearchable` interface.
- Implement specific searchable items (e.g., `MyBook`).
- Search for items using the `Search` class, which operates on the abstraction (`ISearchable`).

---

## Conclusion
The `Coupling.cs` file effectively demonstrates the **Low Coupling** principle by decoupling the `Search` class from specific implementations like `MyBook`. This design ensures modularity, flexibility, and adherence to GRASP principles, making the system easier to maintain and extend.
