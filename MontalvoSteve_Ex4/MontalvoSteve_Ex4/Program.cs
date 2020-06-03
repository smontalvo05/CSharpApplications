using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool to keep the program running until there is no more colors to choose from
            bool ProgramIsRunning = true;

            //instantiating the classes.
            Color colorYellow = new Color("YELLOW");
            Color colorRed = new Color("Red");
            Color colorOrange = new Color("Orange");
            Color colorBlue = new Color("Blue");
            Color colorIndigo = new Color("Indigo");
            Color colorGreen = new Color("Green");
            Color colorViolet = new Color("Violet");
            ColorFactsCollection colorFacts = new ColorFactsCollection();




            //Import the data to the correct class
            colorYellow.ColorFacts[0] = "Did you know that the sun is yellow?";
            colorYellow.ColorFacts[1] = "Did you know that sunflowerd are yellow?";
            colorYellow.ColorFacts[2] = "Did you know that mustard is yellow?";

            //Add it to the dictionary
            colorFacts.ColorFacts["YELLOW"] = (colorYellow);

           
            colorRed.ColorFacts[0] = "Did you know that blood is red?";
            colorRed.ColorFacts[1] = "Did you know that red is not the only color that is a part of the Red Sox's logo?";
            colorRed.ColorFacts[2] = "Did you know that a cardinal is red?";


            colorFacts.ColorFacts["RED"] = (colorRed);

            colorOrange.ColorFacts[0] = "Did you know that Oranges are not Orange?" ;
            colorOrange.ColorFacts[1]=  "Did you know that Pumpkin's are Orange?" ;
            colorOrange.ColorFacts[2]= "Did you know that Pumpkin cake is not Orange?";

            colorFacts.ColorFacts["ORANGE"] = (colorOrange);

            colorBlue.ColorFacts[0] = "Did you know that the sea is not Blue?" ;
            colorBlue.ColorFacts[1]= "Did you know that Blue Whales are really Blue?";
            colorBlue.ColorFacts[2]="Did you know that Bruises are Black and Blue?";

            colorFacts.ColorFacts["BLUE"] = (colorBlue);

            colorIndigo.ColorFacts[0] = "Did you know that Indigo is a city in the United States?" ;
            colorIndigo.ColorFacts[1]="Did you know that Indigo is not a popular color?";
            colorIndigo.ColorFacts[2]="Did you know that Lady Gaga wears Indigo?";

            colorFacts.ColorFacts["INDIGO"] = (colorIndigo);

            colorGreen.ColorFacts[0] = "Did you know that Grass is Green?" ;
            colorGreen.ColorFacts[1]="Did you know that Green Grass Grows?";
            colorGreen.ColorFacts[2]="Did you know that Scotts Miracle Gro makes your grass Greener?";

            colorFacts.ColorFacts["GREEN"] = (colorGreen);

            colorViolet.ColorFacts[0] =  "Did you know that Violet is turning Violet?" ;
             colorViolet.ColorFacts[1]="Did you know that Violet is a hot color on the infrared station?";
             colorViolet.ColorFacts[2]="Did you know that Roses are Red and Violet's are Blue?";

            colorFacts.ColorFacts["VIOLET"] = (colorViolet);

            //Loop to keep the program running
            while (ProgramIsRunning)
            {
                //checking that the dictionary has all of the colors if not it will close.
                if (colorFacts.ColorFacts.Count != 0 )
                {
                    //to keep the program clear from previous messages.
                Console.Clear();
                Console.WriteLine("--------Menu--------\n");
                Console.WriteLine("Which one is your favorite color?\n");
                Console.WriteLine("1. Yellow");
                Console.WriteLine("2. Blue");
                Console.WriteLine("3. Green");
                Console.WriteLine("4. Violet");
                Console.WriteLine("5. Indigo");
                Console.WriteLine("6. Orange");
                Console.WriteLine("7. Red\n");
                Console.Write("Selection: ");
                    //to check the users input to make sure not null or whitespace
                string userInput = Console.ReadLine();
                userInput = UserValidation.IsNullOrWhiteSpace(userInput.ToLower().ToUpper());

                    //to keep the console clear from the previous messages
                    Console.Clear();
                    //informin the user whic menu option they are at
                    Console.WriteLine("--------Color Facts--------\n");
                    //switch statement to check which color the user wants
                    switch (userInput)
                    {
                        case "YELLOW":
                        case "1":
                        case "1.":
                            {

                                //loop to go through the array in color class and make sure its in the dictionary
                                if (colorFacts.ColorFacts.ContainsKey(userInput))
                                {
                                    int i = 0;
                                    foreach (var colorFact in colorYellow.ColorFacts)
                                    {
                                        Console.WriteLine(colorYellow.ColorFacts[i]);
                                        i++;

                                    }
                                    colorFacts.ColorFacts.Remove(userInput);
                                }

                                else
                                {
                                    //to in form the user they choose a correct color or the color is no longer available
                                    Console.WriteLine("Did not choose a correct color or color is no longer available.");

                                }

                            }
                            break;
                        case "VIOLET":
                        case "4":
                        case "4.":
                            {
                                if (colorFacts.ColorFacts.ContainsKey(userInput))
                                {
                                    int i = 0;
                                    foreach (var colorFact in colorViolet.ColorFacts)
                                    {
                                        Console.WriteLine(colorViolet.ColorFacts[i]);
                                        i++;

                                    }
                                    colorFacts.ColorFacts.Remove(userInput);
                                }
                                else
                                {

                                    Console.WriteLine("Did not choose a correct color or color is no longer available.");

                                }
                            }
                            break;
                        case "GREEN":
                        case "3":
                        case "3.":
                            {
                                if (colorFacts.ColorFacts.ContainsKey(userInput))
                                {
                                    int i = 0;
                                    foreach (var colorFact in colorGreen.ColorFacts)
                                    {
                                        Console.WriteLine(colorGreen.ColorFacts[i]);
                                        i++;

                                    }
                                    colorFacts.ColorFacts.Remove(userInput);
                                }
                                else
                                {

                                    Console.WriteLine("Did not choose a correct color or color is no longer available.");

                                }
                            }
                            break;
                        case "BLUE":
                        case "2":
                        case "2.":
                            {
                                if (colorFacts.ColorFacts.ContainsKey(userInput))
                                {
                                    int i = 0;
                                    foreach (var colorFact in colorBlue.ColorFacts)
                                    {
                                        Console.WriteLine(colorBlue.ColorFacts[i]);
                                        i++;

                                    }
                                    colorFacts.ColorFacts.Remove(userInput);
                                }
                                else
                                {

                                    Console.WriteLine("Did not choose a correct color or color is no longer available.");

                                }
                            }
                            break;
                        case "INDIGO":
                        case "5":
                        case "5.":
                            {
                                if (colorFacts.ColorFacts.ContainsKey(userInput))
                                {
                                    int i = 0;
                                    foreach (var colorFact in colorIndigo.ColorFacts)
                                    {
                                        Console.WriteLine(colorIndigo.ColorFacts[i]);
                                        i++;

                                    }
                                    colorFacts.ColorFacts.Remove(userInput);
                                }
                                else
                                {

                                    Console.WriteLine("Did not choose a correct color or color is no longer available.");

                                }

                            }
                            break;
                        case "ORANGE":
                        case "6":
                        case "6.":
                            {
                                if (colorFacts.ColorFacts.ContainsKey(userInput))
                                {
                                    int i = 0;
                                    foreach (var colorFact in colorOrange.ColorFacts)
                                    {
                                        Console.WriteLine(colorOrange.ColorFacts[i]);
                                        i++;

                                    }
                                    colorFacts.ColorFacts.Remove(userInput);
                                }
                                else
                                {

                                    Console.WriteLine("Did not choose a correct color or color is no longer available.");

                                }
                            }
                            break;
                        case "RED":
                        case "7":
                        case "7.":
                            {
                                if (colorFacts.ColorFacts.ContainsKey(userInput))
                                {
                                    int i = 0;
                                    foreach (var colorFact in colorRed.ColorFacts)
                                    {
                                        Console.WriteLine(colorRed.ColorFacts[i]);
                                        i++;

                                    }
                                    colorFacts.ColorFacts.Remove(userInput);
                                }
                                else
                                {

                                    Console.WriteLine("Did not choose a correct color or color is no longer available.");

                                }
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("You have not selected a color within the choices provided please only select form the colors provided.");
                            }
                            break;
                    }
                }
                else
                {
                    //informing the user that the program is closing because there are no more colors available.
                    Console.Clear();
                    Console.WriteLine("--------Program is Closing!--------\n");
                    Console.WriteLine("No More Colors available");
                  
                    ProgramIsRunning = false;
                }
                //space for readability.C
                Console.WriteLine();
                //pausing the program 
                Utility.PauseBeforeContinuing();
            }
            

        }
       
    }
}
