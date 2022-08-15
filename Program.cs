namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console. WriteLine("Choose a Program: \n [1] - Problem: Excellent Grade or Not \n [2] - Problem: Even or Odd \n [3] - Problem: Finding the greater number \n [4] - Problem: Typing a digit in words \n [5] - Problem: Bonus score \n [6] - Problem: Guess the password \n [7] - Mad-Libs");
            int program = int.Parse(Console.ReadLine());
            Console.Clear();

            if (program == 1)
            {
                //! Problem: Excellent Grade or Not
                Console.Write("Enter your grade: ");
                float grade = float.Parse(Console.ReadLine());
                if (grade >= 5.5)
                {
                    Console.WriteLine("Excellent!");
                }
                else
                {
                    Console.WriteLine("Not excellent!");
                }
            }
            else if (program == 2)
            {
                //! Problem: Even or Odd
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else if (program == 3)
            {
                //! Problem: Finding the greater number
                Console.Write("Enter a number 1: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number 2: ");
                int number2 = int.Parse(Console.ReadLine());
                if (number1 > number2)
                {
                    Console.WriteLine(number1);
                }
                else
                {
                    Console.WriteLine(number2);
                }
            }
            else if (program == 4)
            {
                //! Problem: Typing a digit in words
                Console.Write("Enter a digit: ");
                int digit = int.Parse(Console.ReadLine());
                if (digit == 0)
                {
                    Console.WriteLine("Zero");
                }
                else if (digit == 1)
                {
                    Console.WriteLine("One");
                }
                else if (digit == 2)
                {
                    Console.WriteLine("Two");
                }
                else if (digit == 3)
                {
                    Console.WriteLine("Three");
                }
                else if (digit == 4)
                {
                    Console.WriteLine("Four");
                }
                else if (digit == 5)
                {
                    Console.WriteLine("Five");
                }
                else if (digit == 6)
                {
                    Console.WriteLine("Six");
                }
                else if (digit == 7)
                {
                    Console.WriteLine("Seven");
                }
                else if (digit == 8)
                {
                    Console.WriteLine("Eight");
                }
                else if (digit == 9)
                {
                    Console.WriteLine("Nine");
                }
                else
                {
                    Console.WriteLine("Number too big");
                }
            }
            else if (program == 5)
            {
                //! Problem: Bonus score
                Console.Write("Enter your score: ");
                float score = float.Parse(Console.ReadLine());
                float bonus = 0;
                if (Math.Abs(score % 2) == 0)
                {
                    bonus = bonus + 1;
                    Console.WriteLine("Score is even, bonus + 1: {0}", bonus);
                }
                if (Math.Abs(score % 10) == 5)
                {
                    bonus = bonus + 2;
                    Console.WriteLine("Score end with 5, bonus + 2: {0}", bonus);
                }
                if (score > 1000)
                {
                    bonus = bonus + (score/100*10);
                    Console.WriteLine("Score is greater than 1000, bonus + 10%: {0}", bonus);
                }else if (score > 100)
                {
                    bonus = bonus + (score/100*20);
                    Console.WriteLine("Score is greater than 100, bonus + 20%: {0}", bonus);
                }else if (score <= 100)
                {
                    bonus = bonus + 5;
                    Console.WriteLine("Score is up to 100 including, bonus + 5: {0}", bonus);
                }

                Console.WriteLine("Your bonus score is: {0}", bonus);
                Console.WriteLine("Your final score is: {0}", score + bonus);
            }
            else if (program == 6)
            {
                //!Problem: Guess the password
                Console.Write("Enter your guess: ");
                string guess = Console.ReadLine();
                if (guess == "s3cr3t!P@ssw0rd")
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }
            }
            else if (program == 7)
            {
                //! Mad-Libs
                Console.WriteLine("Choose a story: \n [1] - Be Kind \n [2] - Runaway Bride Proposal Ad \n [3] - Sick Note \n [4] - Love Letter");
                int story = int.Parse(Console.ReadLine());

                if (story == 1)
                {
                    Console.Write("Noun: ");
                    string line1 = Console.ReadLine();
                    Console.Write("Noun (plural): ");
                    string line2 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line3 = Console.ReadLine();
                    Console.Write("Place: ");
                    string line4 = Console.ReadLine();
                    Console.Write("Adjective: ");
                    string line5 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line6 = Console.ReadLine();

                    Console.Clear();

                    Console.Write("Mashing Together the Words[::::::]:0%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█:::::]:16%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██::::]:33%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[███:::]:49%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[████::]:66%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█████:]:83%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██████]:100%");
                    System.Threading.Thread.Sleep(1000);

                    Console.Clear();

                    Console.Write("\n Be kind to your {0}-footed {1} \n For a duck may be somebody`s {2}, \n Be kind to your {1} in {3} \n Where the weather is always {4}. \n \n You may think that this is the {5}, \n Well it is.", line1, line2, line3, line4, line5, line6);
                    
                }
                else if (story == 2)
                {
                    Console.Write("Adjective: ");
                    string line1 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line2 = Console.ReadLine();
                    Console.Write("Number: ");
                    string line3 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line4 = Console.ReadLine();
                    Console.Write("Adjective: ");
                    string line5 = Console.ReadLine();
                    Console.Write("Verb: ");
                    string line6 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line7 = Console.ReadLine();
                    Console.Write("Body part: ");
                    string line8 = Console.ReadLine();
                    Console.Write("Adjective: ");
                    string line9 = Console.ReadLine();

                    Console.Clear();

                    Console.Write("Mashing Together the Words[::::::]:0%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█:::::]:16%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██::::]:33%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[███:::]:49%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[████::]:66%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█████:]:83%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██████]:100%");
                    System.Threading.Thread.Sleep(1000);

                    Console.Clear();

                    Console.Write("\n Look, I guarantee there`ll be {0} times. \n I guarantee that at some {1}, {2} or both of us is gonna want to get out of this {3}. \n But I also guarantee that if I don`t ask you to be {4}, I`ll {5} it for the rest of my {6}, because I know, in my {7}, you`re the {8} one for me.", line1, line2, line3, line4, line5, line6, line7, line8, line9);
                }
                else if (story == 3)
                {
                    Console.Write("Silly word: ");
                    string line1 = Console.ReadLine();
                    Console.Write("Last name: ");
                    string line2 = Console.ReadLine();
                    Console.Write("Illness: ");
                    string line3 = Console.ReadLine();
                    Console.Write("Noun (plural): ");
                    string line4 = Console.ReadLine();
                    Console.Write("Adjective: ");
                    string line5 = Console.ReadLine();
                    Console.Write("Adjective: ");
                    string line6 = Console.ReadLine();
                    Console.Write("Silly word: ");
                    string line7 = Console.ReadLine();
                    Console.Write("Place: ");
                    string line8 = Console.ReadLine();
                    Console.Write("Number: ");
                    string line9 = Console.ReadLine();
                    Console.Write("Adjective: ");
                    string line10 = Console.ReadLine();

                    Console.Clear();

                    Console.Write("Mashing Together the Words[::::::]:0%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█:::::]:16%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██::::]:33%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[███:::]:49%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[████::]:66%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█████:]:83%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██████]:100%");
                    System.Threading.Thread.Sleep(1000);

                    Console.Clear();

                    Console.Write("\n Dear School Nurse: \n {0} {1} will not be attending school today. He/she has come down with a case of {2} and has horrible {3} and a/an {4} fever. We have made an appointment with the {5} Dr. {6}, who studied for many years in {7} and has {8} degrees in pediatrics. He will send you all the information you need. Thank you! \n Sincerely \n Mrs. {9}.", line1, line2, line3, line4, line5, line6, line7, line8, line9, line10);
                }
                else if (story == 4)
                {
                    Console.Write("Name of person in room: ");
                    string line1 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line2 = Console.ReadLine();
                    Console.Write("Superlative (ending in 'est'): ");
                    string line3 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line4 = Console.ReadLine();
                    Console.Write("Body part: ");
                    string line5 = Console.ReadLine();
                    Console.Write("Verb (ending in 'ing'): ");
                    string line6 = Console.ReadLine();
                    Console.Write("Noun: ");
                    string line7 = Console.ReadLine();
                    Console.Write("Verb: ");
                    string line8 = Console.ReadLine();
                    Console.Write("Event: ");
                    string line9 = Console.ReadLine();
                    Console.Write("Day if the week: ");
                    string line10 = Console.ReadLine();
                    Console.Write("Verb: ");
                    string line11 = Console.ReadLine();
                    Console.Write("Verb: ");
                    string line12 = Console.ReadLine();
                    Console.Write("Place: ");
                    string line13 = Console.ReadLine();
                    Console.Write("Time span: ");
                    string line14 = Console.ReadLine();
                    Console.Write("Verb: ");
                    string line15 = Console.ReadLine();
                    Console.Write("Adverb: ");
                    string line16 = Console.ReadLine();
                    Console.Write("Name of person in room: ");
                    string line17 = Console.ReadLine();

                    Console.Clear();

                    Console.Write("Mashing Together the Words[::::::]:0%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█:::::]:16%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██::::]:33%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[███:::]:49%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[████::]:66%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[█████:]:83%");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("Mashing Together the Words[██████]:100%");
                    System.Threading.Thread.Sleep(1000);

                    Console.Clear();

                    Console.Write("\n Dear {0}, \n \n It has come to my {1} that you are the {2} girl/boy in the {3}. My {4} starts {5} a {6} every time you speak. I would like to {7} if you want to go to the {8} with me next {9}. If you {12} please {11} me at the {12} in {13}. I {14} you and everything about you. \n \n {15}, \n {16}", line1, line2, line3, line4, line5, line6, line7, line8, line9, line10, line11, line12, line13, line14, line15, line16, line17);
                }
            }
        }
    }
}