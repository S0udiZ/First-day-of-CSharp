namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("Choose a program: \n [1] - Rhombus \n [2] - Volleyball");
			int program = int.Parse(Console.ReadLine());
			Console.Clear();

			if (program == 1)
			{//! Problem: Rhombus made of █ and ■
			Console.Write("Enter rhombus width: ");
			int maxWidth = int.Parse(Console.ReadLine());
			int indent = maxWidth - 1;
			Console.ForegroundColor = ConsoleColor.DarkRed;
			for (int width = 0; width < maxWidth - 1; width++)
			{
				for (int i = width; i < indent; i++)
				{
					Console.Write(" ");
				}
				for (int i = 0; i <= width; i++)
				{
					if (i != width)
					{
						Console.Write("█■");
					}
					else {
						Console.Write("█");
					}
				}
				Console.WriteLine();
			}
			for (int width = maxWidth; width > 0; width--)
			{
				for (int i = width; i <= indent; i++)
				{
					Console.Write(" ");
				}
				for (int i = 0; i < width; i++)
				{
					if (i != width -1)
					{
						Console.Write("█■");
					}
					else {
						Console.Write("█");
					}
				}
				Console.WriteLine();
			}
			Console.ResetColor();}

			if (program == 2)
			{//! Problem: Volleyball
			Console.Write("Enter year type (leap or normal): ");
			string yearType = Console.ReadLine();
			Console.Write("Enter holidays count: ");
			double holidays = double.Parse(Console.ReadLine());
			Console.Write("Enter weekends in hometown: ");
			int hometownWeekends = int.Parse(Console.ReadLine());
			int weekends = 48;
			double totalTimesPlayed = 0;
			
			weekends = weekends / 4 * 3;

			holidays = holidays / 3 * 2;

			if (yearType == "leap")
			{
				totalTimesPlayed = (weekends + holidays) * 1.15;
			}
			else {
				totalTimesPlayed = weekends + holidays;
			}

			Console.WriteLine("TotalTimesPlayed: " + Math.Floor(totalTimesPlayed));}
		}
	}
}
