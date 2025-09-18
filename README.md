# Hell0_TDD

**Project:** Hell0_TDD  
**Purpose:** Demonstrate Test-Driven Development (TDD) in C#  

## Overview
Hell0_TDD is a learning project to demonstrate **Test-Driven Development (TDD)** in C# using xUnit and a class library.  
The project implements a simple ASCII renderer (`AsciiRenderer`) and evolves incrementally using the **Red → Green → Refactor** cycle.  
Future work will integrate **Figgle** to render text in standard ASCII fonts.

This repo showcases a clean commit history that highlights TDD best practices.

## Project Structure
- `Hell0_TDD.Core`  
  Contains the main logic for ASCII rendering. Implemented in a class library (`.dll`), referenced by the test project.  
- `Hell0_TDD.Tests`  
  Contains xUnit tests for `AsciiRenderer`. Demonstrates writing failing tests first, then implementing code to pass them.  

> **Note:** The Core library is not an executable. All functionality is verified through unit tests.

## TDD Workflow Demonstrated
1. **Pre-red / Red**: Added first test for `AsciiRenderer` (test fails, showing test can catch errors).  
2. **Green**: Implemented minimal stub to make test pass.  
3. **Refactor**: Cleaned up `Render` method, added edge-case handling (null, empty, whitespace, trimming).  

## How to Run Tests
1. Open the solution in **Visual Studio 2022**.  
2. Open **Test Explorer** (`Test > Test Explorer`).  
3. Click **Run All** to execute all tests.  
4. Observe **Red → Green** cycles as you implement and refactor code.  

> The Core library itself cannot be run directly; the tests act as the executable driver.

## Getting Started
1. Clone the repository:  
    ```bash
    git clone https://github.com/sooperD00/Hell0_TDD.git
    ```
2. Open the solution `Hell0_TDD.sln` in Visual Studio.
3. Build the solution and run tests via **Test Explorer**.

## Learning Objectives

- [x] Demonstrate **TDD workflow**: write failing test → implement → pass → refactor.
- [x] Practice **unit testing** with xUnit.
- [x] Work with a **class library project** in C#.
- [x] Maintain a clear, professional **commit history** showcasing TDD.
- [x] Integrate external libraries (**Figgle**) for ASCII rendering.

## Next Steps
- [ ] Release as a NuGet package for use in future web project.
- [ ] Create a minimal web front-end (ASP.NET Core or Blazor) that consumes `Hell0_TDD.Core` from NuGet.
- [ ] Set up CI/CD using GitHub Actions to automatically build and test the library.

## License 
MIT License