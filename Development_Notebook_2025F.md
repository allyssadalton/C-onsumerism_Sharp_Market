**CSCI-310 Development Notebook**

---

**Guideline:** 

* Please document all your development activities, whether you use any AI coding tool or not. You might mix your manual coding or AI tool usage. Just document the entire process.   
  * If this is a team project or assignment, list all team members’ names in the “Name” field. For each iteration, record the name of the person who contributed any part of the work in the “What do you do?” field.  
* Any interactions with AI coding tools such as ChatGPT, Gemini, Copilot, and others must capture the full conversation history.   
* Use the format below to record your development activities in a clear and consistent manner.   
  * Adding more iteration sections if needed.

---

#### **Name:**
Allyssa Dalton

#### **Project/Assignment:**
Project 3 - C(onsumerism) Sharp Market
##### **Problem/Task:**
Build a CSharp console game. 
##### **Development Log**

- **Iteration 1:**  
  - **Goal/Task/Rationale:**  
      Create an introduction screen.
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I wrote the introduction paragraph to explain the game and controls. When you press any key, it starts the game.
      
- **Response/Result:**
Finished intro paragraph 

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}
Done

- **Iteration 2:**  
  - **Goal/Task/Rationale:**  
      Create a method for the stats UI
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I created a that clears the console, then shows all player stats
      
- **Response/Result:**

    Finished stats UI
  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}
Done

- **Iteration 3:**  
  - **Goal/Task/Rationale:**  
      Create a UpdatePrice method to update the price of stocks.
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I created a method for the stock prices. There are random events for stock crashes and spikes.
      
- **Response/Result:**
    Method suffcessfully updated stock prices

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}

Done 

- **Iteration 4:**  
  - **Goal/Task/Rationale:**  
      Pause Method
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I created a method that when the esc key is pressed, the game is paused. I also added a Thread.Sleep() method to prevent cpu from overworking
      
- **Response/Result:**
Game can now be paused

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}
Done



- **Iteration 5:**  
  - **Goal/Task/Rationale:**  
      Create reset method
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I created a method that restarts the game by resetting all the variables to their original state and redisplays the introduction paragraph
      
- **Response/Result:**
    You can restart the game

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}

Done


- **Iteration 6:**  
  - **Goal/Task/Rationale:**  
      Create end screen method
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I created an end screen method that displays your final stats.
      
- **Response/Result:**
    Game now has end state

    

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}
Current ethod is done but I want to add some type of memory or somehting so that you can restart and try to beat your previous scores.



- **Iteration 7:**  
  - **Goal/Task/Rationale:**  
      Create prev game memory
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I added variables to keep track of the previous game stats and i created a prevGame boolean variable to check to see if there was a previous game to compare the current stats to 
      
- **Response/Result:**
    You can try to beat your previous networth
  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}
Done but I would like to keep trakc of high scores, if I have the time.



- **Iteration 8:**  
  - **Goal/Task/Rationale:**  
      Changed the time to start at 7 am
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      I changed time to be 420 at the start, and I added an if/else statement to show wether it's am or pm. 
- **Response/Result:**

Time displays prettier
  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}

Done

- **Iteration 9:**  
  - **Goal/Task/Rationale:**  
      Allow for command line interaction for the game
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I created a switch statement for different key pressed and now the cooresponding metnhods are called
      
- **Response/Result:**
Game is playable.

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}
Complete but need to add error catching for non number entries



- **Iteration 10:**  
  - **Goal/Task/Rationale:**  
      Fix issues with the game looping without input
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I included the UpdatePrices() and StatsUI() method in each key press switch instead of calling it at the start of the while (gameRunning) loop
      
- **Response/Result:**
  The game no longer just continues on without input

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}

IT WORKS


- **Iteration 11:**  
  - **Goal/Task/Rationale:**  
      
      Implement win/lose feature
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      I added if your final worth was higher than 1000 you won but if not you lose
- **Response/Result:**
  You can now win or lose 

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}

DOne


- **Iteration 12:**  
  - **Goal/Task/Rationale:**  
      Add high score feature
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I added a highscore feature. If it's your first time playing, you don't get notified you have a new high score. However, if it isnt and you get a new high score, you get told you have a new high score
      
- **Response/Result:**
High score feature works

  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}
Done



- **Iteration 13:**  
  - **Goal/Task/Rationale:**  
      Fix game not restarting after completing it bug
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       I realized the issue occurred from the fact that the while (gameRunning) doesnt start again. I created a method for the game play and then wrapped it in a while(true) loop in main.
      
- **Response/Result:**


  You can now reset the game after finishing

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}

Done


- **Iteration 14:**  
  - **Goal/Task/Rationale:**  
      
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      
- **Response/Result:**


  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}



- **Iteration 15:**  
  - **Goal/Task/Rationale:**  
      
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      
- **Response/Result:**


  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}




- **Iteration 16:**  
  - **Goal/Task/Rationale:**  
      
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      
- **Response/Result:**


  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}




- **Iteration 17:**  
  - **Goal/Task/Rationale:**  
      
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      
- **Response/Result:**


  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}




- **Iteration 18:**  
  - **Goal/Task/Rationale:**  
      
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      
- **Response/Result:**


  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}




- **Iteration 19:**  
  - **Goal/Task/Rationale:**  
      
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      
- **Response/Result:**


  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}




- **Iteration 20:**  
  - **Goal/Task/Rationale:**  
      
      
  - **What do you do?**   
    {If you ask AI, provide your prompt and link. If you fix it yourself, describe how you do it.}  
       
      
- **Response/Result:**


  

- **Your Evaluation:** {Issues/errors/your decision:done/discard/revise prompt}



