# SimpleCalculator

The development of a simple calculator software in C# was aimed at performing the four basic mathematical operations: addition, subtraction, multiplication, and division. The software was structured following best practices for version control, using Git as the management tool.

The branch structure was organized as follows:

1. Master Branch: This is the main branch where the final and stable code of the project is maintained. After development and complete testing, approved functionalities are merged into this branch.

2. Develop Branch: The development branch, where the code is integrated before being tested and validated for production. The functionalities of the four operation modes were initially developed here and then tested and merged into the master branch.

3. Branches for each operation: To facilitate modular and independent development of each calculator function, four dedicated branches were created for each operation mode:
   - feature/sum
   - feature/subtraction
   - feature/multiplication
   - feature/division
   
Each of these branches contains the specific implementation of its respective mathematical operation. Once development was completed and unit tests were performed in each branch, the code was merged into the develop branch for integration, and later into the master after final validation.

# Rounding Feature

In addition to the basic operations, the calculator now includes a feature to round the results to 5 decimal places. This was implemented to ensure precision and avoid displaying excessive decimal numbers caused by floating-point memory behavior. By limiting the output to 5 decimal places, the calculator provides more concise and readable results for the user.

# User Interface

The project adopts a simple console interface where the user is prompted to enter the operation they want to perform by typing a corresponding number or symbol. For example, the user can type 1 for sum, 2 for subtraction, 3 for multiplication, or 4 for division. Once the operation is selected, the user is asked to input two numbers on which the operation will be performed, and the result, rounded to 5 decimal places, is displayed.

This development process using multiple branches ensured better code organization, allowing functionalities to be developed and tested independently, making it easier to detect and fix potential issues before integration into the final product.

# Exception Handling

In addition to handling division by zero, the project includes exception handling for invalid inputs. If the user accidentally types a letter or any other non-numeric character when asked to enter a number, the program catches the error and displays a friendly error message, prompting the user to enter valid numbers. This makes the calculator more user-friendly and robust. 

# How to Execute the Program

1. Download the Project: First, download the project files from the provided repository or as a zip file.

2. Extract the Files: If you downloaded the project as a zip file, extract the contents to a folder on your computer.

3. Open in an IDE: Open the folder in an Integrated Development Environment (IDE) that supports C#, such as Visual Studio or Visual Studio Code with the necessary C# extensions installed.

4. Build the Solution:

   - In Visual Studio, open the .sln (solution) file and navigate to the "Build" menu. Select "Build Solution" or press Ctrl + Shift + B.
   - In Visual Studio Code, open the folder and make sure you have the C# extension installed. Then, navigate to the terminal, and run the command dotnet build to compile the project.
   - 
5. Run the Program: After successfully building the program, you can run it using:

   - Visual Studio: Press F5 or click on "Start" to run the program.
   - Visual Studio Code: Use the command dotnet run in the terminal.

# License

This project is licensed under the MIT License. This means you are free to use, modify, and distribute the software as long as you include the original copyright notice and the license terms. The software is provided "as is", without any warranty, ensuring that the developer is not responsible for any issues that arise from the use of the software.

# Credits

This project was developed by MathiasBergz and jonathanrr-ux. Their collaboration and efforts were key to the successful implementation and release of the calculator software.

# Continuous Updates

The project is actively maintained and updated on a weekly basis. This ensures that new features, bug fixes, and improvements are regularly incorporated, making the calculator more robust and reliable over time.
