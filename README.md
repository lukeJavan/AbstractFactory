# This is a demo application showing the use of the abstract factory design pattern in C#.

## In this example (taken from refactoring guru) we are creating a furniture application factory with 2 different items and 2 different styles.

The first thing the Abstract Factory pattern suggests is to explicitly declare interfaces for each distinct product of the product family (e.g., chair, sofa or coffee table).

Then you can make all variants of products follow those interfaces.

For example, all chair variants can implement the Chair interface; all table variants can implement the Table interface, and so on.

### This pattern follows the Open/Closed principle and the Single Responsibility Principle.
