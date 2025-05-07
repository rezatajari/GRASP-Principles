# PureFabrication.cs

## Overview
The `PureFabrication.cs` file demonstrates the **Pure Fabrication** principle from GRASP (General Responsibility Assignment Software Patterns). Pure Fabrication introduces a class that does not represent a concept in the problem domain but is created to achieve specific design goals, such as reducing coupling, increasing cohesion, or reusing code.

This file provides examples of both failed and successful implementations of the Pure Fabrication principle, focusing on separating domain logic from side effects like sending notifications.

---

## Classes in `PureFabrication.cs`

### **1. PureFabrication**
The `PureFabrication` class is currently a placeholder and does not contain any functionality. It may serve as a conceptual or structural component in the system, potentially to be extended in the future.

---

### **2. User**
The `User` class represents a user in the system. It contains:
- **`Email`**: The email address of the user.

---

### **3. Book**
The `Book` class represents a book in the system. It contains:
- **`Title`**: The title of the book.

#### Failed Implementation of Pure Fabrication:
The `Book` class includes a `Barrow` method that mixes domain logic (marking the book as borrowed) with side effects (sending an email notification). This violates the **Single Responsibility Principle** and increases coupling.

#### Key Issues:
- **Tight Coupling**: The `Book` class depends on email-sending logic, which is unrelated to its primary responsibility.
- **Low Cohesion**: The class handles both domain logic and notification logic, making it harder to maintain and extend.

---

### **4. Controller**
The `Controller` class demonstrates a successful implementation of the Pure Fabrication principle by delegating the responsibility of sending notifications to a separate class (`NotificationService`).

#### Key Method:
- **`BarrowBook(User user, Book book)`**:
  - Handles the borrowing operation by calling the `Barrow` method of the `Book` class.
  - Delegates the responsibility of sending notifications to the `NotificationService`.

---

### **5. NotificationService**
The `NotificationService` class is a **Pure Fabrication**. It is introduced to handle the responsibility of sending email notifications, which is not part of the problem domain but is necessary for the system's functionality.

#### Key Method:
- **`SendEmail(string to, string body)`**:
  - Sends an email to the specified recipient with the given message body.
  - Encapsulates the email-sending logic, reducing coupling and increasing cohesion.

---

## GRASP Principle: Pure Fabrication
The **Pure Fabrication** principle is applied in the `NotificationService` class. By introducing a separate class for sending notifications, the design achieves:
1. **High Cohesion**: The `Book` class focuses solely on domain logic, while the `NotificationService` handles notification logic.
2. **Low Coupling**: The `Book` class no longer depends on email-sending logic, making it easier to modify or replace.
3. **Reusability**: The `NotificationService` can be reused for other notification-related tasks across the system.

---

## Use Case
The `PureFabrication.cs` file can be used in a library management system to:
- Demonstrate the importance of separating domain logic from side effects.
- Provide examples of both failed and successful implementations of the Pure Fabrication principle.
- Highlight the benefits of introducing a Pure Fabrication class like `NotificationService`.

---

## Conclusion
The `PureFabrication.cs` file effectively illustrates the **Pure Fabrication** principle by comparing a failed implementation (mixing domain logic and side effects) with a successful one (delegating side effects to a separate class). This design approach ensures modularity, maintainability, and adherence to GRASP principles.
