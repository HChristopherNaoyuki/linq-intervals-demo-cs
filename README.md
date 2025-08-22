# LINQ Intervals Demo (C#)

This is a simple C# console application demonstrating how to extend LINQ 
functionality using custom extension methods. The project includes a user-defined
method `NewWhere`, which replicates the functionality of the standard LINQ `Where` 
method to filter elements in a collection.

## Features

* Demonstrates creation of custom LINQ-style extension methods.
* Filters an array of integers using a predicate.
* Simple console output for clarity.

## Code Overview

### Entry Point

The `Main` method initializes an array of integers from 1 to 10 and applies the `NewWhere` method to extract only even numbers.

```csharp
var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var even_items = items.NewWhere(x => x % 2 == 0);

foreach(var item in even_items)
{
    Console.WriteLine(item);
}
```

### Custom Extension

The `NewWhere` extension method is defined in the `IEnumerableExtension` static class. It uses `yield return` to lazily evaluate the filtered items.

```csharp
public static IEnumerable<T> NewWhere<T>(
    this IEnumerable<T> items, Func<T, bool> predicate)
{
    foreach (var item in items)
    {
        if (predicate(item))
        {
            yield return item;
        }
    }
}
```

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/HChristopherNaoyuki/linq-intervals-demo-cs.git
```

2. Open the project in Visual Studio or your preferred C# IDE.
3. Build and run the solution.

You should see the even numbers printed to the console:

```
2
4
6
8
10
```

## DISCLAIMER

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY 
IN THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES 
OF THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE 
PROJECT DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED 
ACCORDINGLY TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO 
THE APPLICATION (FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES 
THAT MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. 
IF YOU ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM 
SILENTLY OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST 
OR OPEN AN ISSUE ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN 
BE ADDRESSED APPROPRIATELY BY THE MAINTAINERS OR CONTRIBUTORS.

---
