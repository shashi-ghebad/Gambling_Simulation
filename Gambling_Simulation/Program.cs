using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int stake = 100;
        public static int bet = 1;
        public static int win = 0;
        public static int loss = 0;
        public static int flag = 0;
        int[] cashWon = new int[20];
        int[] cashLoss = new int[20];


        Random random = new Random();

        public void winOrLoss()
        {

            int check = random.Next(0, 2);
            if (check == 1)
            {
                win++;
                stake++;
                Console.WriteLine("Player Win the game");
            }
            else
            {
                loss++;
                stake--;
                Console.WriteLine("Player loss the game");

            }
        }
        public int winOrLossForADay()
        {
            int lossStake = stake / 2;
            int winStake = (stake * 3) / 2;
            bool flag = true;
            while (flag == true)
            {
                int check = random.Next(0, 2);
                if (check == 1)
                {

                    stake++;

                }
                else
                {

                    stake--;
                }
                if (stake == lossStake || stake == winStake)
                {

                    flag = false;
                }
            }

            return stake;

        }

        public void winOrLossFor20Day()
        {
            int lossStake = stake / 2;
            int winStake = (stake * 3) / 2;
            int totalWin = 0;
            int totalLoss = 0;
            int totalCash = 0;

            for (int i = 0; i < 20; i++)
            {
                int cash = stake;
                win = 0;
                loss = 0;
                while (cash > 0)
                {
                    int check = random.Next(0, 2);
                    if (check == 1)
                    {

                        win++;
                        cash++;
                    }
                    else
                    {

                        loss++;
                        cash--;
                    }
                    if (cash == winStake || cash == lossStake)
                    {
                        break;
                    }

                }
                if (win > loss)
                {
                    cashWon[i] = (cash - stake);
                }
                else
                {
                    cashLoss[i] = (stake - cash);
                }
                totalCash = totalCash + cash - stake;
                totalWin = totalWin + win;
                totalLoss = totalLoss + loss;
                cashWon[i] = cash;
                cashLoss[i] = cash;

            }
            Console.WriteLine("Total cash for day: " + totalCash);
            Console.WriteLine();
            for (int i = 0; i < cashWon.Length; i++)
            {
                Console.WriteLine("Cash Won Per day: " + cashWon[i]);
            }
            for (int i = 0; i < cashLoss.Length; i++)
            {
                Console.WriteLine("Cash Loss per day " + cashLoss[i]);
            }
            Console.WriteLine("Number of Winning times:  " + totalWin);
            Console.WriteLine("Number of lossing times:  " + totalLoss);


        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.winOrLossFor20Day();
        }
    }
}