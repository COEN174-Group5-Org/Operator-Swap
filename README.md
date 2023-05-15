# COEN174-Group5-Repo
NOTE: We do not recommend Building and Running the game on your local computer as it requires you to download Unity Hub, Unity, and Unity WebGL Build Support.
Each of these files takes up alot of space and takes a while to download.
You will also need to create an Itch.io account. 
Instead, we recommend you simply play a working build of the game by clicking the link below:

To simply play the game, use the following link:
https://mwgame.itch.io/operator-swap-build-1    
You can tell the game is working and the "smoke test" was a success if you see a main menu screen after clicking "Run Game".
You can also tell that gameplay is working as intended if you see a navy blue screen after clicking "PLAY" from the main menu.

To Build and Run the game you will need to:
1. Download Unity here: 
https://unity.com/download  
    
    a. Make sure to scroll down to where it says: "Create with Unity in three steps"
    
    b. Follow step 1 by downloading the Unity Hub for your OS
    
    c. Follow step 2 by downloading version "2021.3.16" for your OS
2. Link the Github Repository to the Unity Hub
    
    a. Open the Unity Hub
    
    b. In the "Projects" tab, click the "Open" button located near the top right of the window. This should open a file explorer
    
    c. Via the file explorer, navigate to where-ever you have saved a local copy of the Github repository
    
    d. Double click on "COEN174-Group5-Repo"

    e. If the Unity Project does not open up automatically, double click on "COEN174-Group5-Repo" from the Unity Hub

    f. The Unity Project should now open
3. Change the current branch to "Build/Run-Setup"

    a. This should cause your opened Unity Project to reload

    b. If prompted by Unity to reload, click "Reload"
4. Build the Project

    a. Navigate to: File > Build Settings

    b. Look near top of the window and make sure that **ONLY** "Scenes/Title_menu" and "Scenes/SampleScene" have a check mark next to them

    c. If "Scenes/Title_menu" and "Scenes/SampleScene" are not the **ONLY** Scenes with check marks next to them, click on the squares next to them to make sure that **ONLY** "Scenes/Title_menu" and "Scenes/SampleScene" have a check marks next to them and no other Scenes do

    d. Once the "Build Settings" window has opened, locate the "Build" button near the bottom right of the window and click it. **DO NOT CLICK THE BUTTON LABELED "Build and Run", ONLY CLICK "Build"!!!** Clicking "Build" should open a file explorer

    e. Via the file explorer, double click on the "Builds" Folder

    f. Below the folder labeled: "Build 1", right click and make a new folder labeled: "My Build"

    g. Select the "My Build" folder 

    h. Click the "Select Folder" button 

    i. Unity will now build the current branch and put the relevant build files into the "My Build" folder. This may take some time (3-4 mins). A file explorer should open once the process is complete
5. Upload the project build files to Itch.io

    a. From the file explorer that opened in the previous step, double click on the "My Build" folder

    b. Select all the files and compress them to a .zip file

    c. Open a web browser

    d. Visit https://itch.io/

    e. Create an account

    f. Once you have created an account, navigate to the top right of the screen and click the drop down menu that looks like a "V"

    g. Click "Upload new project"

    h. Give the project any title in the "Title" field

    i. Scroll down to the "Uploads" section and click the red "Upload files" button. A file explorer should open

    j. Navigate to where-ever the previously created .zip file is saved and double click it
    
    k. Scoll to the very bottom of the page and click the red "Save & view page" button

6. Play the game (finally)

    a. click "Run Game"

    b. You can tell the game is working and the "smoke test" was a success if you see a main menu screen

    c. Furthermore, you can also tell that gameplay is working as intended by clicking "PLAY" from the main menu after which point you should see a navy blue screen
