using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            int usernum; 
            string[] names = new string[19]; //name array 
            names[0] = "Mace";
            names[1] = "Ty";
            names[2] = "Mauricio";
            names[3] = "Brian";
            names[4] = "Sean O";
            names[5] = "Steve";
            names[6] = "Toney";
            names[7] = "Heather";
            names[8] = "Johnathan";
            names[9] = "Nicholas";
            names[10] = "Andrea";
            names[11] = "Katie";
            names[12] = "David";
            names[13] = "Rudy";
            names[14] = "Jackie";
            names[15] = "Camille";
            names[16] = "Clayton";
            names[17] = "Levi";
            names[18] = "Evan";
            string[] hometown = new string[19]; //hometwon array
            hometown[0] = "Detroit";
            hometown[1] = "Pontiac";
            hometown[2] = "Bloomfield Hills";
            hometown[3] = "Anna Arbor";
            hometown[4] = "Flint";
            hometown[5] = "Toledo";
            hometown[6] = "Troy";
            hometown[7] = "Detroit";
            hometown[8] = "Grand Rapids";
            hometown[9] = "Pontiac";
            hometown[10] = "Detroit";
            hometown[11] = "Saginaw";
            hometown[12] = "Bloomfield Hills";
            hometown[13] = "Detroit";
            hometown[14] = "Grosse Point";
            hometown[15] = "Flint";
            hometown[16] = "Anna Arbor";
            hometown[17] = "Grosse Point";
            hometown[18] = "Waterville";
            string[] food = new string[19]; //food array
            food[0] = "Pizza";
            food[1] = "Pasta";
            food[2] = "Raman";
            food[3] = "Burgers";
            food[4] = "Chicken Shawarma";
            food[5] = "French Fries";
            food[6] = "Sushi";
            food[7] = "Cake";
            food[8] = "Chocolate";
            food[9] = "Pizza";
            food[10] = "Ramna";
            food[11] = "Chcolate";
            food[12] = "Tacos";
            food[13] = "Pasta";
            food[14] = "Sushi";
            food[15] = "Chicken Shawarma";
            food[16] = "Cake";
            food[17] = "Pizza";
            food[18] = "Grilled Octopus";


            bool exitProg = false;
            while (exitProg == false) //while loop for the whole program
            {
                Console.WriteLine("Welcom to our C# class.");

                while (true) // while loop for student name
                {
                    Console.WriteLine("Which student would you like to learn more about? (Enter a number 0 - 18)");
                    try //try for 
                    {

                        usernum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Student {0}:", names[usernum]);
                        break;
                    }

                    catch (IndexOutOfRangeException) //incase user goes out of range it catches these two exeptions
                    {
                        Console.WriteLine("That student doesn't exist, try agian");
                        continue;
                    }


                    catch (FormatException)
                    {
                        Console.WriteLine("That student doesn't exist, try agian");
                        continue;
                    }

                }

                Console.WriteLine("Would you like to know more about this student? Enter hometown or favoritefood ");
                string input = Console.ReadLine().ToLower();
                while (input != "hometown" && input != "favoritefood")// loop for the hometown/favoritefood validation
                {

                    Console.WriteLine("That data type does not exist try agian");


                     input = Console.ReadLine().ToLower(); //reading user input
                }

                        if (input == "hometown") //if hometown it prints else food
                        {
                            Console.WriteLine("{0} is from {1}", names[usernum], hometown[usernum]);
                        }

                        else 
                        {
                            Console.WriteLine("{0} favorite food is {1}", names[usernum], food[usernum]);
                        }

                    while (true) // while loop for the user to continue
                    {
                        Console.WriteLine("Would you like to continue y/n ?");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "y") //if yes it breaks this loops and the false function runs it back to the top of the program loop
                        {
                            exitProg = false; 
                            break;
                        }

                        else if (answer == "n")//if no it breaks the loop agian but true function ends the program; n
                        {
                            exitProg = true;
                            break;
                        }


                        else if (answer != "y" || answer != "n") //if anything other then y or n it continues to ask the user
                        {
                            Console.WriteLine("Would you like to continue y/n ?");
                            answer = Console.ReadLine();
                            continue;
                        }

                    }



                }


            }


        }

    }

