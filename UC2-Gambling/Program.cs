using System;

namespace UC2_Gambling
{
	class Program
	{
		public const int WIN = 1;
		public const int STAKE = 100;
		public const int BET = 1;
		static void Main(string[] args)
		{
			int amountLeft = 100;
			Random random = new Random();
			int win_loss = random.Next(0, 2);
			if (win_loss == WIN)
			{
				amountLeft = STAKE + BET;
			}
			else
			{
				amountLeft = STAKE - BET;
			}
			Console.WriteLine("The amount I have lefft after betting is: " + amountLeft);
			Console.ReadLine();
		}
	}
}
