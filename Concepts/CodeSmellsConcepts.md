# Code Smells

## Common Code Smells

### Long methods

- Make code hard to maintain and debug – consider breaking up into smaller methods

### Refuse Bequest

- When a class inherits from a base class and doesn’t use any of the inherited methods

### Data clumps

- When multiple method calls take the same parameters

### Duplicate code

- A developer fixes a bug, only for the same bug to then resurface somewhere else in the code

Other common code smells include: Middle Man, Primitive Obsession

Good read: [Common Code Smells](https://8thlight.com/blog/georgina-mcfadyen/2017/01/19/common-code-smells.html)

## SOLID Principles

SOLID principles are part of Robert C Martin's (Uncle Bob) wider set of suggested software design principles.  They are usually applied to Object Oriented code design and are as follows:

- **S** - Single Responsibility Principle
  - A class should only have a single responsibility
    - There should be only one trigger to mean a change in the class is necessary

- **O** - Open-Closed Principle
  - Code should be open for extension but closed for modification

- **L** - Liskov Substitution Principle (aka design by contract)
  - "Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program"
  - In other words you must be able to substitute a base class with any class that extends it

- **I** - Interface Segregation Principle
  - Interfaces should not be made generic, its better to have specific interfaces specific to the client that will implement them

- **D** - Dependency Inversion Principle
  - "Depend upon abstractions, not concretions

There are many resources that explain and exemplify these principles, 'Uncle Bob' being one of them...[The Principles of OOD](http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod)
