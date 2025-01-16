# Prime Number Checker

A **sleek and vibrant** C# program designed to determine if a given number is prime, bringing functionality and elegance together in true **SkeptiKrafts** style.

---

## Features

- **Graceful Validation**: No more clunky errors! Handles invalid input with finesse using `int.TryParse()`.
- **Reusable Intelligence**: Encapsulated prime-checking logic in a smart, reusable `IsPrime()` method.
- **Streamlined Performance**: Optimized logic to check divisors only up to the square root of the number. Efficient, because time is precious.
- **User-Centric Experience**: Clear, dynamic output that resonates with the user, making every interaction purposeful.
- **Thoughtful Edge Case Handling**: Numbers less than or equal to 1? We’ve got them covered. Simplified logic meets thoughtful design.

---

## What’s New?
- **Validation**:  
  Enhanced with `int.TryParse()` to handle user input like a pro and prevent runtime hiccups.  

- **Reusable Logic**:  
  The `IsPrime()` method is your reliable go-to for prime-checking brilliance.  

- **Optimized Elegance**:  
  Re-engineered the loop to run from `2 to √number`, minimizing unnecessary calculations. Smart and fast.  

- **Dynamic Interaction**:  
  Clear and lively output, personalized with the user's entered number. Simple yet engaging.  

- **Comprehensive Edge Handling**:  
  Numbers ≤ 1 are no longer a mystery. They’re explicitly handled with clarity and precision.  

---

## Usage
1. Clone this thoughtfully designed repository or copy the elegant code into your C# console application.
2. Fire it up in Visual Studio or your IDE of choice.
3. Enter a number and enjoy the polished experience as you discover its primality.

---

## Sample Output

**Input**:  
```
Enter a number to test if it is a prime number:
7
```

**Output**:  
```
7 is a Prime Number.
```

**Input**:  
```
Enter a number to test if it is a prime number:
10
```

**Output**:  
```
10 is NOT a Prime Number.
```

---

## Installation
1. Install the intuitive [.NET SDK](https://dotnet.microsoft.com/download) if not already installed.
2. Run the elegant `Program.cs` file using:
   ```bash
   dotnet run
   ```

---

## Contributing
Got an idea or a spark of inspiration? Fork it, refine it, and submit a pull request. Let’s build brilliance together—the **SkeptiKrafts** way.

---

## License
This project is licensed under the [APACHE License](LICENSE). Bringing innovation and simplicity together.
