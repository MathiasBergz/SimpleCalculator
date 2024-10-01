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
   - 
Each of these branches contains the specific implementation of its respective mathematical operation. Once development was completed and unit tests were performed in each branch, the code was merged into the develop branch for integration, and later into the master after final validation.

The project adopts a simple console interface where the user is prompted to enter the operation they want to perform by typing a corresponding number or symbol. For example, the user can type 1 for sum, 2 for subtraction, 3 for multiplication, or 4 for division. Once the operation is selected, the user is asked to input two numbers on which the operation will be performed, and the result is displayed.

This development process using multiple branches ensured better code organization, allowing functionalities to be developed and tested independently, making it easier to detect and fix potential issues before integration into the final product.

# License

This project is licensed under the MIT License. This means you are free to use, modify, and distribute the software as long as you include the original copyright notice and the license terms. The software is provided "as is", without any warranty, ensuring that the developer is not responsible for any issues that arise from the use of the software.

# Credits

This project was developed by MathiasBergz and jonathanrr-ux. Their collaboration and efforts were key to the successful implementation and release of the calculator software.

# Continuous Updates

The project is actively maintained and updated on a weekly basis. This ensures that new features, bug fixes, and improvements are regularly incorporated, making the calculator more robust and reliable over time.
