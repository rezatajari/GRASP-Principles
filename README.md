# GRASP Principles: Hands-On Practice

Welcome to the **GRASP Principles** repository! This project is designed to help developers understand and practice the **General Responsibility Assignment Software Patterns (GRASP)** principles through hands-on examples. Each principle is demonstrated with practical code and detailed documentation to showcase its importance in building modular, maintainable, and scalable software systems.

---

## What Are GRASP Principles?

GRASP principles are a set of guidelines for assigning responsibilities to classes and objects in object-oriented design. These principles help developers create systems that are:
- **Modular**: Easy to understand and modify.
- **Maintainable**: Changes in one part of the system have minimal impact on others.
- **Scalable**: New features can be added without breaking existing functionality.

The principles covered in this repository include:
1. **Information**
2. **Creator**
3. **Coupling**
4. **Cohesion**
5. **Controller**
6. **Pure Fabrication**
7. **Indirection**
8. **Polymorphism**

---

## Repository Structure

This repository is organized into two main sections:
1. **Code**: Demonstrates the implementation of GRASP principles in C#.
2. **Documentation**: Explains the concepts, workflows, and benefits of each principle.

---

## GRASP Principles in Action

### 1. Information
The **Information** principle focuses on how information is encapsulated and managed within a system. It ensures that classes are designed to handle the data they own effectively.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/Information.md)

### 2. Creator
The **Creator** principle assigns the responsibility of creating an object to a class that has the necessary information to initialize it or closely uses it.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/Creator.md)

### 3. Coupling
The **Coupling** principle ensures that classes and components in a system are minimally dependent on each other, improving modularity and flexibility.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/Coupling.md)

### 4. Cohesion
The **Cohesion** principle ensures that a class has a well-defined purpose and contains only closely related responsibilities.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/Cohesion.md)

### 5. Controller
The **Controller** principle assigns the responsibility of handling system operations to a class that represents a use-case scenario or a role in the system.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/Controller.md)

### 6. Pure Fabrication
The **Pure Fabrication** principle introduces a class that does not represent a concept in the problem domain but is created to achieve specific design goals, such as reducing coupling or increasing cohesion.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/PureFabrication.md)

### 7. Indirection
The **Indirection** principle introduces an intermediary to mediate between two components or layers, such as database access and business logic, to achieve low coupling.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/Indirection.md)

### 8. Polymorphism
The **Polymorphism** principle allows behavior to vary based on the type of object, enabling dynamic method dispatch and eliminating conditional logic.  
[Read the full documentation here](https://github.com/rezatajari/GRASP-Principles/blob/master/doc/Polymorphism.md)

---

## Why Use GRASP Principles?

By following GRASP principles, you can:
- **Improve Code Quality**: Create systems that are easier to understand, maintain, and extend.
- **Reduce Technical Debt**: Minimize the risk of introducing bugs when adding new features.
- **Enhance Collaboration**: Make it easier for teams to work on the same codebase by adhering to clear design guidelines.

   