# Prime Number Checker

A simple C# program to determine whether a given number is a prime number.

---

## Features

- **Validates User Input**: Handles invalid input gracefully using `int.TryParse()`.
- **Reusable Functionality**: Implements a reusable `IsPrime()` method to encapsulate prime-checking logic.
- **Optimized Performance**: Uses an optimized loop to check divisors only up to the square root of the number.
- **Enhanced User Experience**: Displays clear, dynamic output with the user's entered number.
- **Edge Case Handling**: Explicitly excludes numbers less than or equal to 1 from being considered prime.

---

## What’s New?
- **Validation**:  
  Used `int.TryParse()` to handle invalid user input gracefully and prevent runtime errors.  

- **Functionality**:  
  Introduced a reusable `IsPrime()` method to encapsulate the logic for checking whether a number is prime.  

- **Optimization**:  
  Improved performance by reducing the loop range from `1 to number` to `2 to √number`.  

- **User Experience**:  
  Added dynamic output that displays the user's entered number in the result message for clarity.  

- **Edge Cases**:  
  The `IsPrime()` method now explicitly handles numbers ≤ 1, which are not prime by definition.  

---

## Usage
1. Clone the repository or copy the code into a C# console application.
2. Run the program in Visual Studio or your preferred IDE.
3. Enter a number when prompted to check if it is a prime number.

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
1. Install [.NET SDK](https://dotnet.microsoft.com/download) if not already installed.
2. Compile and run the `Program.cs` file using:
   ```bash
   dotnet run
   ```

---

## Contributing
Feel free to fork the project, make improvements, and submit a pull request. Contributions are always welcome!

---

## License
This project is licensed under the [APACHE License](LICENSE).
