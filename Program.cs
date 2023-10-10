//Kyle Solesbee 10/10/23
//Student Database Lab

namespace StudentDatabaseLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = { "Joe", "Rob", "Steve", "Trent" };
            string[] studentHometown = { "Wyandotte", "Dearborn", "Decatur", "Kansas City" };
            string[] studentFavFood = { "Pizza", "Chicken", "Burgers", "Tacos" };
            string[] categories = { "Hometown", "Favorite Food" };
            string repeat;

            int studentNumber;

            bool goAgain = true;

            while (goAgain) 
            {
                DisplayListOfStudents(studentNames);

                studentNumber = GetStudentNumber(studentNames);

                DisplayStudentInfo(studentNumber, studentNames, studentHometown, studentFavFood, categories);

                Console.WriteLine("Do you want to go again? (yes/no)");
                repeat = Console.ReadLine();

                if(repeat != "yes")
                {
                    goAgain = false;
                }
            }
            
            
        }

        static void DisplayListOfStudents(string[] studentNames)
        {
            int studentNum = 1;
            string input;
            bool goAgain = true;

            while (goAgain)
            {
                Console.WriteLine("Would you like a list of students before starting? (yes/no)");
                input = Console.ReadLine();

                if (input != "no")
                {
                    for (int i = 0; i < studentNames.Length; i++)
                    {
                        Console.WriteLine($"{studentNum}. {studentNames[i]}");
                        studentNum++;
                    }
                    
                    goAgain = false;
                }
                else
                {
                    break;
                }
            }

        }

        static int GetStudentNumber(string[] studentNames) 
        {
            int studentNumber;

            while (true)
            {
                Console.WriteLine("Please enter a student number (1 to " + studentNames.Length + "):");
                string input = Console.ReadLine();

                if(int.TryParse(input, out studentNumber))
                {
                    if(studentNumber >= 1 && studentNumber <=studentNames.Length)
                    {
                        return studentNumber;
                    }
                    else
                    {
                        Console.WriteLine("WRONG! ERROR! You're lucky you can try again. Now please enter a number between 1 and " + studentNames.Length + ".");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR! Please type a valid number: ");
                }
            }
            
        }

        static void DisplayStudentInfo(int studentNumber, string[]studentNames, string[] studentHometown, string[] studentFavFood, string[] categories)
        {
            string input;

            Console.WriteLine("You selected student: " + studentNames[studentNumber - 1]);

            Console.WriteLine("Which category would you like to choose? Hometown or Favorite Food?");
            input = Console.ReadLine().Trim().ToLower();
            input.Contains(input);

            if(input != " ")
            {
                foreach(string category in categories)
                {
                    if(category.ToLower().Contains(input.Trim().ToLower()))
                    {
                        input = category.ToLower();
                        break;
                    }
                }
            }

            if(input == "hometown")
            {
                Console.WriteLine(studentNames[studentNumber - 1] + "'s hometown is: " + studentHometown[studentNumber - 1]);
            }
            else if(input == "favorite food")
            {
                Console.WriteLine(studentNames[studentNumber - 1] + "'s favorite food is: " + studentFavFood[studentNumber - 1]);
            }
            else
            {
                Console.WriteLine("WRONG! ERROR! You're lucky you can try again. Now please enter 'Hometown' or 'Favorite Food'.");
            }
        }
    }
}