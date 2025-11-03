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

    static void IntroScreen()
    {
        Console.Clear();
        Console.WriteLine(@"
                                                        Welcome to C(onsumerism) Sharp Market!
                            --------------------------------------------------------------------------------------------------
                                        You are a stock market trader watching live stock market prices.
                                Your goal is to maximize profit before the trading day ends at 4pm without insider trading.
                                                        Prices change every few seconds. 
                                                Buy when prices are low, sell when prices are high. 
                                              Watch out! Stocks can randomly crash or spike in price. 
                                                   
                                                                     Controls:
                                                                      B - Buy
                                                                      S - Sell
                                                                N - Skip/Wait One Tick
                                                                    R - Restart
                                                                    ESC - Pause
                                                                      Q - Quit
                                                                      
                                                      Press any key to open up Sharp Street
                                                              
        ");
        while (true)
        {
            if (Console.KeyAvailable) { break; }
        }
    }

    static void StatsUI(){
        int netWorth = cash + (stocks * price);
        Console.Clear();
        Console.WriteLine("[B] - Buy [S] - Sell [N] - Skip/Wait One Tick [R] - Restart [ESC] - Pause [Q] - Quit");
        Console.WriteLine("----------------------------------------");
        if (time >= 720){
            if (time < 780) { Console.WriteLine($"Time: 	12:{time % 60:D2}PM"); }
            else { Console.WriteLine($"Time: {(time / 60 % 12)}:{time % 60:D2}PM"); }
        }
        else { Console.WriteLine($"Time: {(time / 60 % 12)}:{time % 60:D2}AM"); }
        Console.WriteLine($"Money: ${cash}");
        Console.WriteLine($"Stocks Owned: {stocks}");
        Console.WriteLine($"Current Price: %{price}");
        Console.WriteLine($"Net Worth: ${netWorth}");
        Console.WriteLine("----------------------------------------");
    }

    static void UpdateStockPrice(){
        int change = rand.Next(-10, 11);
        price += change;
        if (price < 1) { price = 1; }
        int chaoticEventChance = rand.Next(1, 20);
        if (chaoticEventChance == 1) {
            int spike = rand.Next(20, 40);
            price += spike;
            Console.WriteLine($"Stock Prices Spiked!! They increased by ${spike}.");
        }

        else if (chaoticEventChance == 2) {
            int drop = rand.Next(20, 40);
            price -= drop;
            Console.WriteLine($"Stock Prices Crashed!! They decreased by ${drop}.");
        }
        else {Console.WriteLine($"Stock prices are now {price}.");}
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
        IntroScreen();
    }

    static void EndScreen(){
        int finalWorth = cash + (stocks * price);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Time: 4:00pm");
        Console.WriteLine("Sharp Street is now closed.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Final Cash: ${cash}");
        Console.WriteLine($"Stocks Owned: {stocks}");
        Console.WriteLine($"Net Worth: ${finalWorth}");

        if (prevGame){
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Previous Attempt Stats:");
            Console.WriteLine($"Final Cash: ${prevCash}");
            Console.WriteLine($"Stocks Owned: {prevStocks}");
            Console.WriteLine($"Net Worth: ${prevNetWorth}");

            if (prevNetWorth > finalWorth){
                Console.WriteLine("You did not beat your previous Final Net Worth.");
                Console.WriteLine("Booooooo!!!!! Maybe next time. :(");
                Console.WriteLine("----------------------------------------");
            }

            else{
                Console.WriteLine("You did beat your previous Final Net Worth!!!!!!");
                Console.WriteLine("Great job!!!!! I'm so proud of you. You're becoming the best stock buying in the world!!!!!");
                Console.WriteLine("----------------------------------------");
            }
        }

        Console.WriteLine($"Press R to play again and try to beat your net worth or Q to quit.");
        Console.WriteLine("----------------------------------------");

        while (true){
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


    static void Main(string[] args){
        IntroScreen();
        StatsUI();
        gameRunning = true;

        while (gameRunning){
            Thread.Sleep(2000);
            time += 2;

            UpdateStockPrice();
            StatsUI();
             
            if (time >= 960){
                EndScreen();
                continue;
            }
            if (Console.KeyAvailable) {
                switch (Console.ReadKey(true).Key) {
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
                        Console.WriteLine("How many stocks would you like to buy: ");
                        num = int.Parse(Console.ReadLine());
                        if (cash >= num * price) {
                            cash -= num * price;
                            stocks += num;
                        }
                        else {
                            num = price / cash;
                            Console.WriteLine($"You only have enough cash for {num} stocks.");
                            cash -= num * price;
                            stocks += num;
                        }
                        Console.WriteLine($"Successfully bought {num} stocks for {price} each!");
                        break;

                    case ConsoleKey.S:
                        Console.WriteLine("How many stocks would you like to sell: ");
                        num = int.Parse(Console.ReadLine());
                        if (stocks >= num) {
                            cash += num * price;
                            stocks -= num;
                        }
                        else {
                            num = stocks;
                            Console.WriteLine($"You only have {stocks} stocks.");
                            cash += num * price;
                            stocks = 0;
                        }
                        Console.WriteLine($"Successfully sold {num} stocks for {price} each!");
                        break;
                }
            }
            Thread.Sleep(100); 
        }
    }
}
