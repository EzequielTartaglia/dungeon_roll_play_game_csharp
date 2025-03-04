# Dungeon Roll Play Game C#

## Overview

This project is a role-playing game (RPG) developed in C#. The goal of this software is to demonstrate object-oriented programming principles such as inheritance, polymorphism, and encapsulation while creating an interactive game. The project includes base and derived character classes, inventory management, and combat mechanics.

Through this project, I aimed to deepen my understanding of C# syntax and game development concepts. The implementation showcases the use of constructors, method overriding, and object interactions in a structured and maintainable manner.

[Software Demo Video](https://youtu.be/bBIiYf2_Uyk)

## Class Structure

### Base Classes
- **BaseNPCharacter**: Represents non-player characters (NPCs) with combat behaviors.
- **BasePlayerCharacter**: Represents player-controlled characters with additional capabilities such as using potions and upgrading skills.
- **Item & Inventory**: Manage game items and collections.
- **Battle System**: Helper to manage battles.

### Derived Classes
- **NPCBanshee, NPCOrc, NPCSkullWarrior**: Inherit from `BaseNPCharacter` but do not introduce additional behaviors.
- **PJArcher, PJKnight, PJWizard**: Inherit from `BasePlayerCharacter` and override base behaviors using virtual methods.

### Constructors
Each class is designed with multiple constructors:
- A default constructor initializing attributes with default values.
- Overloaded constructors allowing flexible object creation with different parameter sets.
- Derived classes call base constructors to ensure proper initialization.


## Development Environment

- **Programming Language**: C#
- **IDE**: Visual Studio
- **Diagram Tool**: [Visual Paradigm Online](https://online.visual-paradigm.com/app/diagrams/#)

## Useful Websites
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Stack Overflow](https://stackoverflow.com/)
- [Game Development Patterns](https://gameprogrammingpatterns.com/)

## Future Work
- Expand hero customization (e.g., skill trees).
- Introduce simple dungeon exploration mechanics.
- Add multiplayer (local or online) for cooperative gameplay.
