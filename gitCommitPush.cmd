rem do this first -> git remote set-url origin https://gitlab.com/widmersoftworks/eeec.git
@echo off
set /p commitMessage="Enter Commit Message: "
D:
cd "C:\Users\ron\source\repos\TestPuttingTheDnDInTDD"
git add -A
git commit -m "%commitMessage%"
git push -u origin master
pause
