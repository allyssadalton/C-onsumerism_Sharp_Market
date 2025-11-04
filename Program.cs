using System;

using System.Threading;

class Program{
    static bool gameRunning = false;
    static bool gamePaused = false;
    static int price = 50;
    static int cash = 1000;
    static int stocks = 0;
    static int time = 420; //7am
    static bool prevGame = false;
    static Random rand = new Random();
    static int prevCash, prevStocks, prevNetWorth;
    static int num;
    static int highscore = 0;

    static void IntroScreen(){
        Console.WriteLine(@"
                                                        Welcome to C(onsumerism) Sharp Market!
                            --------------------------------------------------------------------------------------------------
                                        You are a stock market trader watching live stock market prices.
                                Your goal is to maximize profit before the trading day ends at 4pm without insider trading.
                                                                    
                                                Buy when prices are low, sell when prices are high. 
                                              Watch out! Stocks can randomly crash or spike in price. 
                                         If you end the day with a lower net worth than you started, you LOSE!
                                                   
                                                                     Controls:
                                                                      B - Buy
                                                                      S - Sell
                                                                N - Skip/Wait One Tick
                                                                    R - Restart
                                                                    ESC - Pause
                                                                      Q - Quit
                                                                      
                                                      Press any key to open up Sharp Street
                                                              
        ");
        /*while (true){
            ConsoleKey key = Console.ReadKey(true).Key;
            if (Console.KeyAvailable) { break; }
        }*/
        Console.ReadKey(true);
        
    }

    static void StatsUI(){
        int netWorth = cash + (stocks * price);
        Console.WriteLine("----------------------------------------");
        if (time >= 720){
            if (time < 780) { Console.WriteLine($"Time: 	12:{time % 60:D2}PM"); }
            else { Console.WriteLine($"Time: {(time / 60 % 12)}:{time % 60:D2}PM"); }
        }
        else { Console.WriteLine($"Time: {(time / 60 % 12)}:{time % 60:D2}AM"); }
        Console.WriteLine($"Money: ${cash}");
        Console.WriteLine($"Stocks Owned: {stocks}");
        if (netWorth <= 1000) { Console.ForegroundColor = ConsoleColor.Red; }
        else{ Console.ForegroundColor = ConsoleColor.Green; }
        Console.WriteLine($"Net Worth: ${netWorth}");
        Console.ResetColor();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("[B] - Buy [S] - Sell [N] - Skip [R] - Restart [ESC] - Pause [Q] - Quit");
        
    }

    static void UpdateStockPrice(){
        int change = rand.Next(-10, 11);

        Console.WriteLine("");
        price += change;
        if (price < 1) { price = 1; }
        int chaoticEventChance = rand.Next(1, 20);
        if (chaoticEventChance == 1) {
            int spike = rand.Next(20, 40);
            price += spike;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Stock Prices Spiked!! They increased by ${spike}.");
            Console.ResetColor();
        }

        else if (chaoticEventChance == 2) {
            int drop = rand.Next(20, 40);
            if (drop > price) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Stock Prices Crashed!!");   
                price = 1;
            }
            else {
                price -= drop;
                Console.WriteLine($"Stock Prices Crashed!! They decreased by ${drop}.");
                Console.ResetColor();
            }
            
        }
        Console.WriteLine($"Stock prices are now {price}.");
    }

    static void PauseScreen() {
        gamePaused = true;
        Console.WriteLine("Game Paused. Press ESC to resume.");
        while (true){
            if (Console.KeyAvailable){
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
                if (keyInfo.Key == ConsoleKey.Escape){
                    gamePaused = false;
                    StatsUI();
                    break;
                }
            }
            Thread.Sleep(100);
        }
    }

     static void ResetGame(){
        price = 50;
        cash = 1000;
        stocks = 0;
        time = 420;
        //IntroScreen();
        GamePlay();
    }

    static void EndScreen() {
        int finalWorth = cash + (stocks * price);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Time: 4:00pm");
        Console.WriteLine("Sharp Street is now closed.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Final Cash: ${cash}");
        Console.WriteLine($"Stocks Owned: {stocks}");
        Console.WriteLine($"Net Worth: ${finalWorth}");
        if (highscore > 0) {
            if (highscore < finalWorth) {
                Console.WriteLine("You got a new highscore!");
                highscore = finalWorth;
            }
        }
        else { highscore = finalWorth; }

        if (prevGame) {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Previous Attempt Stats:");
            Console.WriteLine($"Final Cash: ${prevCash}");
            Console.WriteLine($"Stocks Owned: {prevStocks}");
            Console.WriteLine($"Net Worth: ${prevNetWorth}");

            if (prevNetWorth > finalWorth) {
                Console.WriteLine("You did not beat your previous Final Net Worth.");
                Console.WriteLine("Booooooo!!!!! Maybe next time. :(");
                Console.WriteLine("----------------------------------------");
            }

            else {
                Console.WriteLine("You did beat your previous Final Net Worth!!!!!!");
                Console.WriteLine("Great job!!!!! I'm so proud of you. You're becoming the best stock buying in the world!!!!!");
                Console.WriteLine("----------------------------------------");
            }
        }
        if (finalWorth > 1000) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You win!!");
            Console.WriteLine($"Your final networth of ${finalWorth} was higher than the starting networth of $1,000.");
            Console.ResetColor();
        }
        else {
            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!!");
                Console.WriteLine($"Your final networth of ${finalWorth} was less than the starting networth of $1,000.");
            Console.ResetColor();

        }

        Console.WriteLine($"Highscore: ${highscore}");

        Console.WriteLine($"Press R to play again and try to beat your net worth or Q to quit.");
        Console.WriteLine("----------------------------------------");

        while (true) {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.R) {
                prevGame = true;
                prevCash = cash;
                prevStocks = stocks;
                prevNetWorth = finalWorth;
                ResetGame();
                break;
            }
            else if (key == ConsoleKey.Q) {
                gameRunning = false;
                break;
            }
        }
    }
    
    static void GamePlay() {
        gameRunning = true;
        Console.Clear();
        UpdateStockPrice();
        StatsUI();
        while (gameRunning) {
            if (time >= 960) {
                EndScreen();
                continue;
            }
            DateTime startWait = DateTime.Now;
            bool gotInput = false;

            // Wait up to 5 seconds for input
            while ((DateTime.Now - startWait).TotalSeconds < 5) {
                if (Console.KeyAvailable) {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    Console.WriteLine("");
                    switch (key) {
                        case ConsoleKey.Escape:
                            PauseScreen();
                            break;
                        case ConsoleKey.R:
                            ResetGame();
                            break;
                        case ConsoleKey.Q:
                            EndScreen();
                            break;
                        case ConsoleKey.B:
                            Console.Write("How many stocks would you like to buy: ");
                            string? input = Console.ReadLine();
                            if (int.TryParse(input, out num)) {
                                if (cash >= num * price) {
                                    cash -= num * price;
                                    stocks += num;
                                }
                                else {
                                    num = cash / price;
                                    Console.WriteLine($"You only have enough cash for {num} stocks.");
                                    cash -= num * price;
                                    stocks += num;
                                }
                                Console.WriteLine($"Successfully bought {num} stocks at ${price} each!");
                            }
                            time += 60;
                            UpdateStockPrice();
                            StatsUI();
                            break;


                        case ConsoleKey.S:
                            Console.Write("How many stocks would you like to sell: ");
                            input = Console.ReadLine();
                            if (int.TryParse(input, out num)) {
                                if (stocks <= num) {
                                    cash += num * price;
                                    stocks -= num;
                                }
                                else {
                                    num = stocks;
                                    Console.WriteLine($"You only have enough stocks to sell {stocks} stocks.");
                                    cash += num * price;
                                    stocks = 0;
                                }
                                Console.WriteLine($"Successfully sold {num} stocks at ${price} each!");
                                time += 60;
                                UpdateStockPrice();
                                StatsUI();
                            }
                            break;

                        case ConsoleKey.N:
                            time += 60;
                            UpdateStockPrice();
                            StatsUI();
                            break;
                    }
                    gotInput = true;
                    break;
                }
            }
            if (!gotInput) {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You didn't make a move. Stock market updated.");
                Console.ResetColor();
                time += 60;
                Thread.Sleep(1000);
                UpdateStockPrice();
                StatsUI();
            }
        }
    }



    static void Main(string[] args) {
        while (true) {
            IntroScreen();
            Console.Clear();
            GamePlay();
        }
    }
}
