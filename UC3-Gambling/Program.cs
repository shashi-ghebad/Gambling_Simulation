using System;

namespace UC3_Gambling
{
	class Program
	{
		public const int WIN = 1;
		public const int STAKE = 100;
		public const int BET = 1;
		public static void callMethod()
		{
			int amountLeft = 100;
			//int numOfBets = 0;
			Random random = new Random();
			while (amountLeft != amountLeft / 2 || amountLeft == amountLeft + 50)
			{
				//numOfBets++;
				int win_loss = random.Next(0, 2);
				if (win_loss == WIN)
				{
					amountLeft = amountLeft + BET;
					Console.WriteLine(amountLeft);
					if (amountLeft == 150)
						break;
				}
				else
				{
					amountLeft = amountLeft - BET;
					Console.WriteLine(amountLeft);
					if (amountLeft == 50)
						break;
				}
			}
			Console.WriteLine("The amount I have left after betting is: " + amountLeft);
		}
		static void Main(string[] args)
		{
			callMethod();
			Console.ReadLine();
		}
	}
}
