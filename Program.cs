using System;

class Program{
    static bool running = true;
    static bool paused = false;
    static int price = 50;
    static int cash = 1000;
    static int stock = 0;
    static int timeLeft = 540; // 9 minutes 
    static Random rand = new Random();
    
    
    static void Main(string[] args){
        Console.WriteLine(@"
                                                    Welcome to C(onsumerism) Sharp Market! 
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
                                                              
        ");
        
        while (gameRunning){
            
        }
    }
}