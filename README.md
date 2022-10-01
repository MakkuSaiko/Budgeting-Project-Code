# Budgeting-Project-Code
Code used to randomize production and sales figures for the 2022 budgeting project

Description of randomization:

Constants used:
- Maximum annual production
- Given monthly limit of production (to prevent maximum annual productions being fulfilled in a small amount of months)
- Maximum production per month (Calculated: Maxiumum production per day * nr of days for that month)

Comments:
- Nr of days for each month and month names taken in via text files (Months.txt)
- Constants used for budgeting project:
  - Maximum annual production: 10000 units
  - Monthly limit of production: 1000 units
  - Maximum production per month: 200 units
  

Randomization process:
1. Get random production total between 0 and Maximum production per month
2. If above limit is bigger than the monthly limit: Get a new random production between 0 and the montly limit
3. If the current random production is bigger than the remaining annual production set the production to the remaining annual production
4. Decrement the remaining Annual production by the random production used


# How to run: 
Required .NET Framework 5.0
Download first:
1. [Download here](https://github.com/MakkuSaiko/Budgeting-Project-Code/releases/download/submission/Executables.zip)

Run:
1. Extract files from ZIP
2. Launch ConsoleApp2.exe
3. Follow on screen prompts

Please note that this is a console app and will simply run in the terminal
All work done by Adriaan Benn
