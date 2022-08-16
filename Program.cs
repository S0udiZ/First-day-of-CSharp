namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			Console. WriteLine("Choose a Program: \n [1] - Problem: Summing up numbers \n [2] - Problem: Min number \n [3] - Problem: Left and right sum \n [4] - Problem: Chinema \n [5] - Problem: Sum of vowels \n [6] - Problem: Sum of consonants \n [7] - Hospital");
            int program = int.Parse(Console.ReadLine());
            Console.Clear();

			if (program == 1)
			{//! Problem: Summing up numbers
			Console.Write("How many numbers do you want to sum up? ");
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				sum += number;
			}
			Console.WriteLine($"The sum is {sum}");}

			if (program == 2)
			{//! Problem: Min number
			Console.Write("How many numbers do you want to compare? ");
			int n = int.Parse(Console.ReadLine());
			int min = int.MaxValue;
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				if (number < min)
				{
					min = number;
				}
			}
			Console.WriteLine($"The min number is {min}");}

			if (program == 3)
			{//! Problem: Left and right sum
			Console.Write("How many numbers do you want to sum and compare? ");
			int n = int.Parse(Console.ReadLine());
			int leftSum = 0;
			int rightSum = 0;
			Console.WriteLine("Left side:");
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				leftSum += number;
			}
			Console.WriteLine("Right side:");
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				rightSum += number;
			}
			if (leftSum == rightSum)
			{
				Console.WriteLine($"Yes, sum = {leftSum}");
			}
			else
			{
				Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
			}}

			if (program == 4)
			{//! Problem: Chinema
			string[ , ] typesOfScreening = {{"Premiere", "12"},{"Normal", "7,50"},{"Discount", "5"} };
			Console.Write("Types of screenings: ");
			for (int i = 0; i < typesOfScreening.Length/2; i++)
			{
				Console.Write($"\n {typesOfScreening[i, 0]} ");
			}
			Console.Write("\n Choose a type of screening: ");
			string type = Console.ReadLine();
			Console.Write("How many rows are there? ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write("How many columns are there? ");
			int columns = int.Parse(Console.ReadLine());
			int seats = rows * columns;
			for (int i = 0; i < typesOfScreening.Length/2; i++)
			{
				if (typesOfScreening[i, 0] == type)
				{
					double total = seats * double.Parse(typesOfScreening[i, 1]);
					Console.WriteLine($"The price of the ticket is {typesOfScreening[i, 1]} EUR");
					Console.WriteLine($"The income from the screening is " + total.ToString("F") + " EUR");
				}
			}}

			if (program == 5)
			{//! Problem: Sum of vowels
			Console.Write("Enter a word: ");
			string word = Console.ReadLine();
			int sum = 0;
			string vowels = "";
			for (int i = 0; i < word.Length; i++)
			{
				switch (word[i])
				{
					case 'a':
						sum += 1;
						vowels += "a";
						break;
					case 'e':
						sum += 2;
						vowels += "e";
						break;
					case 'i':
						sum += 3;
						vowels += "i";
						break;
					case 'o':
						sum += 4;
						vowels += "o";
						break;
					case 'u':
						sum += 5;
						vowels += "u";
						break;
					case 'y':
						sum += 6;
						vowels += "y";
						break;
					
				}
			}
			Console.WriteLine($"The sum of the vowels is {sum}");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("(");
			Console.ForegroundColor = ConsoleColor.Blue;
			for (int i = 0; i < vowels.Length; i++)
			{
				Console.Write($"{vowels[i]}");
				if (i != vowels.Length - 1)
				{
					Console.Write(" + ");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write(" = ");
				}
			}
			Console.ForegroundColor = ConsoleColor.Red;
			for (int i = 0; i < vowels.Length; i++)
			{
				if (vowels[i] == 'a')
				{
					Console.Write("1");
				}
				else if (vowels[i] == 'e')
				{
					Console.Write("2");
				}
				else if (vowels[i] == 'i')
				{
					Console.Write("3");
				}
				else if (vowels[i] == 'o')
				{
					Console.Write("4");
				}
				else if (vowels[i] == 'u')
				{
					Console.Write("5");
				}
				else if (vowels[i] == 'y')
				{
					Console.Write("6");
				}

				if (i != vowels.Length - 1)
				{
					Console.Write(" + ");
				}
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write($" = {sum})");
			Console.ResetColor();}

			if (program == 6)
			{//! Problem: Sum of consonants
			Console.Write("Enter a word: ");
			string word = Console.ReadLine();
			int sum = 0;
			string consonants = "";
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] != 'a' && word[i] != 'e' && word[i] != 'i' && word[i] != 'o' && word[i] != 'u' && word[i] != 'y')
				{
					sum += word[i] - 'a';
					consonants += word[i];
				}
			}
			Console.WriteLine($"The sum of the consonants is {sum}");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("(");
			Console.ForegroundColor = ConsoleColor.Blue;
			for (int i = 0; i < consonants.Length; i++)
			{
				Console.Write($"{consonants[i]}");
				if (i != consonants.Length - 1)
				{
					Console.Write(" + ");
				}
				else
				{
					Console.Write(" = ");
				}
			}
			Console.ForegroundColor = ConsoleColor.Red;
			for (int i = 0; i < consonants.Length; i++)
			{
				Console.Write(consonants[i] - 'a');
				if (i != consonants.Length - 1)
				{
					Console.Write(" + ");
				}
				else
				{
					Console.Write(" = ");
				}
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write($" = {sum})");
			Console.ResetColor();}

			if (program == 7)
			{//! Problem: Hospital
			int docters = 7;
			int patients = 0;
			int treatedPatients = 0;
			int untreatedPatients = 0;
			Console.Write("Enter the period of time in days: ");
			int days = int.Parse(Console.ReadLine());
			for (int i = 1; i <= days; i++)
			{
				Console.WriteLine($"Day{i}: ");
				// Checks if there are more untreated patients than doctors if so, another doctor is added
				if (i % 3 == 0 && treatedPatients < untreatedPatients)
				{
					Console.WriteLine("There are more untreated patients than treated patients, another doctor is added");
					docters++;
					Console.WriteLine($"There are now {docters} doctors");
				}
				Console.Write($"Enter the number of patients on day {i}: ");
				patients = int.Parse(Console.ReadLine());
				// Calculates the number of treated patients and the number of untreated patients
				if (patients > docters)
				{
					treatedPatients += docters;
					untreatedPatients += patients - docters;
				}
				else
				{
					treatedPatients += patients;
				}
			}
			Console.WriteLine($"Treated patients: {treatedPatients}");
			Console.WriteLine($"Untreated patients: {untreatedPatients}");}
		}
	}
}
