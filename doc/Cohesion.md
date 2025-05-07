# Documentation: Cohesion.cs

## Overview
The `Cohesion.cs` file demonstrates the concept of **High Cohesion**, a key principle in GRASP (General Responsibility Assignment Software Patterns). High cohesion ensures that a class has a well-defined purpose and contains only closely related responsibilities, making it easier to maintain, understand, and extend.

---

## Classes in `Cohesion.cs`

### **1. Cohesion**
The `Cohesion` class is currently a placeholder and does not contain any functionality. It may serve as a conceptual or structural component in the system, potentially to be extended in the future.

---

### **2. MagazineWithoutCohesion**
The `MagazineWithoutCohesion` class is an example of **Low Cohesion**. It combines unrelated responsibilities, which violates the principle of high cohesion.

#### Key Issues:
- **Unrelated Responsibilities**:
  - The class manages magazine-related data (e.g., `Title`, `Author`, `IsBorrowed`) and behaviors (e.g., `IsAvailable`).
  - It also includes user-related data (`UserEmail`) and authentication logic (`Login`), which are unrelated to the magazine's primary purpose.
- **Impact of Low Cohesion**:
  - The class becomes harder to maintain and extend.
  - Changes to one responsibility (e.g., authentication) may inadvertently affect unrelated responsibilities (e.g., magazine management).

---

### **3. MagazineCohesion**
The `MagazineCohesion` class is an example of **High Cohesion**. It focuses solely on responsibilities related to managing a magazine.

#### Key Properties and Methods:
- **Properties**:
  - `Title`: The title of the magazine.
  - `Author`: The author of the magazine.
  - `IsBorrowed`: Indicates whether the magazine is borrowed.
- **Methods**:
  - `IsAvailable()`: Determines if the magazine is available for borrowing.
  - `Barrow()`: Marks the magazine as borrowed.
  - `Return()`: Marks the magazine as returned.

#### Benefits of High Cohesion:
- **Clarity**: The class has a single, well-defined purpose.
- **Maintainability**: Changes to the class are localized and do not affect unrelated responsibilities.
- **Reusability**: The class can be reused in different contexts without modification.

---

## GRASP Principle: High Cohesion
The **High Cohesion** principle is applied in the `MagazineCohesion` class. By focusing solely on magazine-related responsibilities, the class achieves:

    1. **Modularity**: The class is self-contained and easy to understand.
    2. **Separation of Concerns**: Unrelated responsibilities (e.g., user authentication) are not included in the class.
    3. **Ease of Maintenance**: The class is easier to modify and extend without introducing unintended side effects.

---

## Use Case
The `Cohesion.cs` file can be used in a library management system to:
- Demonstrate the importance of high cohesion in class design.
- Provide examples of both low cohesion (`MagazineWithoutCohesion`) and high cohesion (`MagazineCohesion`).

---

## Conclusion
The `Cohesion.cs` file effectively illustrates the importance of **High Cohesion** in class design. By comparing `MagazineWithoutCohesion` and `MagazineCohesion`, it highlights the benefits of focusing on a single, well-defined responsibility. This design approach ensures modularity, maintainability, and adherence to GRASP principles.
