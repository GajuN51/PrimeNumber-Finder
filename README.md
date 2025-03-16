# Windows Forms Prime Number Calculator

A Windows Forms (WinForms) desktop application built in C# to compute prime numbers using multithreading.

## Features  
- Find prime numbers up to a given number  
- Multi-threaded execution to prevent UI freezing  
- Dual input support for two independent calculations  
- Non-blocking UI to allow interactions during computations  

## How It Works  
1. Enter a number in **Textbox 1**, then click **Button 1 (Calculate 1)**  
   - Prime numbers up to the entered number will be displayed in **ListBox 1**  
   - Runs in a separate thread to avoid UI freezing  

2. Enter a number in **Textbox 2**, then click **Button 2 (Calculate 2)**  
   - Prime numbers up to the entered number will be displayed in **ListBox 2**  
   - Runs in a separate thread to enable parallel execution  

Both computations can run simultaneously without blocking each other.  

## Technologies Used  
- C# (Windows Forms Application)  
- .NET Framework  
- Multithreading using Tasks  

## Getting Started  

### Clone the Repository  
