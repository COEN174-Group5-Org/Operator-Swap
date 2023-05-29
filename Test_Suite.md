Test Suite for this Project
Card Functionality
1.  Card Functionality Test #1
	a. Action: Hover mouse over card. 
b. Expected output: The card should have a hover animation. 
2.  Card Functionality Test #2
	a. Action: Click on an operand card and move the mouse around the screen. 
	b. Expected output: The operand card should follow the mouse, moving wherever the mouse is. 
3.  Card Functionality Test #3
	a. Action: Click on an operator card and move the mouse around the screen. 
	b. Expected output: The operator card should follow the mouse, moving wherever the mouse is. 
4.  Card Functionality Test #4
	a. Action: With an operand card selected, move it to an operand game slot and click. 
	b. Expected output: The selected operand card should slot into the operand slot 
5.  Card Functionality Test #5
	a. Action: With an operator card selected, move it to an operator game slot and click. 
	b. Expected output: The selected operator card should slot into the operand slot 
6.  Card Functionality Test #6
	a. Action: With an operator card selected, move it to an operand game slot and click. 
	b. Expected output: The selected operator card should not slot into the operand slot. The card should stay attached to the mouse. 
7.  Card Functionality Test #7
	a. Action: With an operand card selected, move it to an operator game slot and click. 
	b. Expected output: The selected operand card should not slot into the operator slot. The card should stay attached to the mouse. 


8.  Card Functionality Test #8
	a. Action: With an operand card selected, click ‘escape.’
	b. Expected output: The pause menu should appear, the selected operand card should stop following the mouse and remain where it was when ‘escape’ was clicked. The mouse should be free to move around the screen. 
9.  Card Functionality Test #9
	a. Action: With an operand card selected, click ‘escape.’ Move the mouse to somewhere else on the screen and click ‘escape’ again.
	b. Expected output: After the pause menu appears, upon clicking escape again, the pause menu should disappear and the card should snap to wherever the mouse is.  
10.  Card Functionality Test #10
	a. Action: With an operand card selected, click ‘escape.’ Move the mouse to the ‘resume’ button and click it.
	b. Expected output: After the pause menu appears, upon clicking resume, the pause menu should disappear and the card should snap to wherever the mouse is.  
11.  Card Functionality Test #11
	a. Action: With an operand card selected, click the ‘pause’ button.
	b. Expected output: The pause menu should appear, the selected operand card should stop following the mouse and remain where it was when the pause button was clicked. The mouse should be free to move around the screen. 
12.  Card Functionality Test #12
	a. Action: With an operand card selected, click the ‘pause’ button. Move the mouse to somewhere else on the screen and click ‘escape’.
	b. Expected output: After the pause menu appears, upon clicking escape again, the pause menu should disappear and the card should snap to wherever the mouse is.  
13.  Card Functionality Test #13
	a. Action: With an operand card selected, click the ‘pause’ button. Move the mouse to the ‘resume’ button and click it.
	b. Expected output: After the pause menu appears, upon clicking resume, the pause menu should disappear and the card should snap to wherever the mouse is.  
14.  Card Functionality Test #14
	a. Action: With an operator card selected, click ‘escape.’
	b. Expected output: The pause menu should appear, the selected operand card should stop following the mouse and remain where it was when ‘escape’ was clicked. The mouse should be free to move around the screen. 
15.  Card Functionality Test #15
	a. Action: With an operator card selected, click ‘escape.’ Move the mouse to somewhere else on the screen and click ‘escape’ again.
	b. Expected output: After the pause menu appears, upon clicking escape again, the pause menu should disappear and the card should snap to wherever the mouse is.  
16.  Card Functionality Test #16
	a. Action: With an operator card selected, click ‘escape.’ Move the mouse to the ‘resume’ button and click it.
	b. Expected output: After the pause menu appears, upon clicking resume, the pause menu should disappear and the card should snap to wherever the mouse is.  
17.  Card Functionality Test #17
	a. Action: With an operator card selected, click the ‘pause’ button.
	b. Expected output: The pause menu should appear, the selected operand card should stop following the mouse and remain where it was when the pause button was clicked. The mouse should be free to move around the screen. 
18.  Card Functionality Test #18
	a. Action: With an operator card selected, click the ‘pause’ button. Move the mouse to somewhere else on the screen and click ‘escape’.
	b. Expected output: After the pause menu appears, upon clicking escape again, the pause menu should disappear and the card should snap to wherever the mouse is.  
19.  Card Functionality Test #19
	a. Action: With an operator card selected, click the ‘pause’ button. Move the mouse to the ‘resume’ button and click it.
	b. Expected output: After the pause menu appears, upon clicking resume, the pause menu should disappear and the card should snap to wherever the mouse is.  
Pause Functionality
20.  Pause Functionality Test #1
	a. Action: Move the mouse to the pause button in the top left of the screen.
	b. Expected output: A darkened button silhouette should appear. 
21.  Pause Functionality Test #2
	a. Action: Move the mouse to the pause button in the top left of the screen. Click it. 
	b. Expected output: The pause menu should appear. The game should stop. There should be a dark overlay. 
22.  Pause Functionality Test #3
	a. Action: Click ‘escape’.
	b. Expected output: The pause menu should appear. The game should stop. There should be a dark overlay. 
23.  Pause Functionality Test #4
	a. Action: With the pause menu open, hover over resume and click. 
	b. Expected output: The pause menu should disappear. The game should resume. The dark overlay should disappear. 
24.  Pause Functionality Test #5
	a. Action: With the pause menu open, click ‘escape’. 
	b. Expected output: The pause menu should disappear. The game should resume. The dark overlay should disappear. 
25.  Pause Functionality Test #6
	a. Action: With the pause menu open, hover over the ‘menu’ button and click. 
	b. Expected output: The screen should switch to the main menu title screen.
Main Menu Functionality
26.  Main menu Functionality Test #1
	a. Action: Press Start Button
	b. Expected output: Transition from main menu scene to the first gameplay scene
27.  Main menu Functionality Test #2
	a. Action: Press How To Play Button
	b. Expected output: Transition from main menu scene to the How To Play Scene
28.  Main menu Functionality Test #3
	a. Action: Press Lore Button
	b. Expected output: Transition from main menu scene to the Lore Screen Scene
Objective Generator Functionality
29.  Objective Generator Functionality Test
	a. Action: Find the script “GenerateObjective.cs”, open it, and change the line private bool debug = false; to private bool debug = true;. Compile and run the game with the debug log open.
	b. Expected output: The debug log now outputs diagnostics on a randomly generated debug objective every 64 frames, including the 5 random hand operands, the 4 random hand operators, up to 100 possible output values, the chosen objective both as a string and a token, and whether or not the objective can be completed.
