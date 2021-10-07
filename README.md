# Welcome to the Game Engine Midterm Repository

Game Instructions:

In order to play, please unzip the "MidtermBuild.zip" file. In the unzipped folder, you'll find the "MidtermProject.exe" file. Run this file and enjoy the game!

 
Project Description: 

Uses a DLL to generate a random position for the enemies. You are in control of a player that needs to avoid the enemies, otherwise you lose.

External Assets Acknowledgement:

- Used Unity 3D Models (Sphere, Capsule, Cube)

DLL Files:

To switch between the modified DLL and original DLL, there is a folder in the root of the repository called "PluginProject". In there, you will find two folders, one called
"ModifedPlugin", and anothe called "OriginalPlugin". The ModifiedPlugin folder contains the DLL which generates random positions. The OriginalPlugin folder contains the DLL
which does not change anything.

In order to change the DLL of the build, you’ll need to open up the Extracted Game from the MidtermBuild.zip file. Then navigate inside the MidtermProject_Data folder, then go inside the Plugins folder, then go inside the x86_64 folder, then copy and paste the dll inside this folder with either the ModifiedPlugin DLL, or OriginalPlugin DLL.

Controls: 

Movement: WASD Keys
Jump: Space Key

Youtube Demo Video:

https://youtu.be/9GxmHbHcWY8