namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Selection = '\0';
            List<int> Inputs = new List<int>();
            
            do
            {
                Console.WriteLine("---------------------- \n Main manu");
                Console.WriteLine("\n P - Print numbers" +
                    " \n A - Add a number" +
                    " \n M - Display mean of the numbers" +
                    " \n S - Display the smallest number" +
                    " \n L - Display the largest number"+
                    " \n C - Clear list"+
                    " \n Q - Quit");
                Console.WriteLine("Enter your selection: ");
                Selection = char.ToUpper(char.Parse(Console.ReadLine()));

                switch (Selection)
                {
                    case 'P':
                        {
                            if (Inputs.Any())
                            {
                                Console.WriteLine($"[ {string.Join(" ", Inputs)} ]");
                            }
                            else
                            {
                                Console.WriteLine("List is empty");
                            }
                            break;
                        }

                    case 'A':
                        {
                            int number = 0;
                            Console.WriteLine("Enter number :");
                            number = Convert.ToInt32(Console.ReadLine());
                            Inputs.Add(number);
                            Console.WriteLine($"{number} is added");
                            break;
                        }
                   
                    case 'M': 
                        {
                            if (Inputs.Count > 0)
                            {
                                double sum = 0;
                                for (int i = 0; i < Inputs.Count; i++)
                                {
                                    sum += Inputs[i];
                                }
                                double mean = sum / Inputs.Count;
                                Console.WriteLine($"The mean of numbers : {mean}");
                            }
                            else
                            {
                                Console.WriteLine("List empty");
                            }
                            break;
                        }
                   
                    case 'S':
                        {
                            if ( Inputs.Count > 0 )
                            {
                                int smallest = Inputs[0];
                                for (int i = 1; i < Inputs.Count; i++)
                                {
                                    if (Inputs[i] < smallest)
                                    {
                                        smallest = Inputs[i];
                                    }
                                }
                                Console.WriteLine("the smallest number : " + smallest);
                            }
                            else
                            {
                                Console.WriteLine("list empty");
                            }
                            break;
                        }
                   
                    case 'L':
                        {
                            if (Inputs.Count > 0)
                            {
                                int largest = Inputs[0];
                                for (int i = 1; i < Inputs.Count; i++)
                                {
                                    if (Inputs[i] > largest)
                                    {
                                        largest = Inputs[i];
                                    }
                                }
                                Console.WriteLine("the Largest number : " + largest);
                            }
                            else
                            {
                                Console.WriteLine("list empty");
                            }
                            break;
                        }
                   
                    case 'C':
                        {
                            Inputs.Clear();
                            Console.WriteLine("List empty");
                            break;
                        }
                   
                    case 'Q':
                        {
                            Console.WriteLine("Good bye");
                            break;
                        }
                   
                    default:
                        Console.WriteLine("Unknown selection");
                        break;
                }
            } while (Selection != 'Q');
        }
    }
}
