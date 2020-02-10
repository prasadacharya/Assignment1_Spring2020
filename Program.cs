/* 
 Author : Prasad Acharya
 Start Date : 1/23/2020
 Comments : This C# Console Application code demonstrates the Assignment1_Spring2020 
*/

using System;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This method prints number pattern of integers using recursion");
            int n = 5;
            //int n = 10;
            PrintPattern(n);
            Console.WriteLine();

            Console.WriteLine("This method prints the series till n terms");
            int n2 = 6;
            //int n2 = 11;
            PrintSeries(n2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("This method prints the UsfTime");
            string s = "09:15:35PM";
            //string s = "03:40:12AM";
            string t = UsfTime(s);
            Console.WriteLine(t);
            Console.WriteLine();

            Console.WriteLine("This method prints the UsfNumbers");
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);
            Console.WriteLine();

            Console.WriteLine("This method prints the Palindrome Pairs");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            //string[] words = new string[] { "bat", "tab", "cat" };
            PalindromePairs(words);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("This method prints the stone game result");
            int n4 = 4;
            //int n4 = 5;
            //Console.WriteLine("Enter number of stones:");
            //int n4 = Convert.ToInt32(Console.ReadLine());
            Stones(n4);
            Console.WriteLine();
            Console.WriteLine();

        } // end of Main




        /* This method prints number pattern of integers using recursion
         * Time taken : 1.5 hour
         * Learning : int and string datatype, Recursion, if and For loop */
        private static void PrintPattern(int n)
        {
            try
            {
               
                if (n < 1)
                {  //Base case return if number reaches '0'
                    return;
                }  // end of if 

                /* Logic : build the number string using the for loop appending numbers starting from n decrementing by 1 till it reach 1. 
                   Print number string. Go to next line. Then call the function recursively for the next smaller number n - 1 */

                String str = "";
                for (int i = n; i >= 1; i--)
                {
                    str += i; //Create number string by appending successive decreasing value
                } // end of for loop
                Console.Write(str); // print number string 
                Console.WriteLine(); // go to next line
                PrintPattern(n - 1); // Recursively call the function for the next lower number
            } // end of try
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            } // end of catch
        } // end of PrintPattern


        /*
         // Below program also prints number pattern as above using nested for loop without using recursion
         // Time taken : 1 hour
         // Learning : Nested For loop
           private static void PrintPattern(int n)
           {
               try
               {
                   //Outer for loop will execute n times
                       for (int i = 0; i <= n; i++)
                       {
                       //inner for loop will decrement by one each time and print all numbers until 1 in descending order
                           for (int j = n - i; j >= 1; j--)
                           {
                               Console.Write(j);
                           } // end of inner for loop

                           Console.Write("\n"); // go to next line

                       } // end of outer for loop
               } // end of try
               catch
               {
                   Console.WriteLine("Exception Occured while computing printPattern");
               } // end of catch
           } // end of PrintPattern
           */




        /* This method prints the series till n terms
         * Time taken : 1 hour
         * Learning : int data type, For loop */
        private static void PrintSeries(int n2)
        {
            try
            {

                /* Logic : initialised sum variable to 0. For each iteration Sum value will increment by next integer and print it.
                 * Sum value for each iteration will be 1,1+2=3,1+2+3=6,1+2+3+4=10,1+2+3+4+5=15, 1+2+3+4+5+6=21……*/
                int sum = 0;

                for (int i = 1; i <= n2; i++)
                {
                    sum = sum + i;
                    Console.Write("{0},",sum);
                } // end of for loop

            } // end of try
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries.");
            } // end of catch
        } // end of PrintSeries




        /* This method prints the UsfTime
         * Time taken : 2.5 hour
         * Learning : DateTime and String datatype, type conversion, return string value */
        public static string UsfTime(string s)
        {
            try
            {
                /* Logic : Converted string input to DateTime format and calculated total number of seconds in Input time.
                 Divided those seconds according to USF time and created UsfTime string */

                DateTime date12 = Convert.ToDateTime(s); // Converted string input to DateTime format.
                String time24 = date12.ToString("HH:mm:ss"); // converted time to 24 hour format
                int seconds = (int)TimeSpan.Parse(time24).TotalSeconds; // calculated total seconds

                // calculated hour(h) = total seconds/number of seconds in each USF hour(60*45)
                int h = (seconds / 2700);

                // calculated minutes(m) = (total seconds - total number of hours in seconds(2700 * h)) / number of seconds in each minute
                int m = (seconds - (2700 * h)) / 45;

                //calculated seconds = total seconds-total number of hours in seconds(2700 * h)-total number of minutes in seconds(m * 45)
                int sec = (seconds - (2700 * h) - (m * 45)); 

                String time36 = h.ToString()+":"+m.ToString()+":"+sec.ToString(); // converted h,m,sec to Usf format Time string 
                return time36;            // returned UsfTime string   
            } // end of try
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
                return null;
            } // end of catch          
        }// end of UsfTime




        /* This method prints the UsfNumbers
         * Time taken : 2 hour
         * Learning : if-elseif-else, for loops */
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
              /*Logic:This method will check all conditions using "if-else if-else" loops and print Usf Numbers accordingly from 1 to 110, 
               *11 numbers per line. Used modulo operation to find out numbers multiple of 3, 5 and 7.Line by Line logic provided below */

                for (int i = 1; i <= n3; i++)
                {
                    //if number is multiple of 3,5 and 7 then print 'USF'

                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                        Console.Write("USF");

                    //if number is multiple of 3 and 5 then print 'US'
                    else if (i % 3 == 0 && i % 5 == 0)
                        Console.Write("US");
                    //if number is multiple of 5 and 7 then print 'SF'
                    else if (i % 5 == 0 && i % 7 == 0)
                        Console.Write("SF");
                    //if number is multiple of 3 and 7 then print 'UF'
                    else if (i % 3 == 0 && i % 7 == 0)
                        Console.Write("UF");

                    //if number is multiple of 3 then print 'U'
                    else if (i % 3 == 0)
                        Console.Write("U");
                    //if number is multiple of 5 then print 'S'
                    else if (i % 5 == 0)
                        Console.Write("S");
                    //if number is multiple of 7 then print 'F'
                    else if (i % 7 == 0)
                        Console.Write("F");

                    //else print number 
                    else
                        Console.Write(i);
                    //to add space between numbers
                        Console.Write(" ");

                    //to print k(=11) numbers per line
                    if (i % k == 0)
                    {
                        Console.Write("\n");

                    } // end of if loop
                } // end of for loop
            } // end of try
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers().");
            } // end of catch
        } // end of UsfNumbers




        /* This method prints the Palindrome Pairs
         * Time taken : 2.5 hour
         * Learning : strings and array, nested for loops, if statement, palindrome */
        public static void PalindromePairs(string[] words)
        {
            try
            {

             /*Logic :Concatenate 2 different words from given array. Check if the concatenation of two words is a palindrome by 
              * comparing string "str" with reverse of that string "revs".If they are same that means string is palindrome hence 
              * printing indices of those two words. Repeat the same for all different pairs */

                int n = words.Length; // to get the length of the array

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            String str = words[i] + words[j]; // to concatenate two words and store it in String "str"

                            String revs = "";  // to store reverse of String "str"

                            for (int k = str.Length - 1; k >= 0; k--) //to Reverse the String "str"   
                            {
                                revs += str[k];
                            }// end of for loop

                            //Checking whether String "str" is palindrome or not by comparing it with reverse of that String "revs"
                            if (revs == str) 
                            {
                                Console.Write("[{0} {1}]", i, j);
                            }// end of inner if
                        }//end of outer if
                    }// end of inner for loop
                }// end of outer for loop
            }// end of try
            catch
            {
                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }// end of catch
        } // end of PalindromePairs




        /* This method prints the stone game result
*         Time taken : 3 hour
*         Learning : do while loops, if statement, Random class */
        public static void Stones(int n4)
       {
           try
           {
                /* Logic 1:  You(Player 1) cannot win this stone game if the number of stones in the bag is divisible by 4. 
                 * Because No matter 1,2 or 3 stones you(Player 1) take out, the last stone will always be removed by Player 2. 
                 * It is obvious that the same pattern repeats itself for n=4,8,12,16,…, basically all multiples of 4. 
                 * Assumption: Both players are very clever and have optimal strategies for the game. */

                if (n4 % 4 == 0)
                {
                    Console.WriteLine("False(You cannot win the game)");
                }//end of if

                /* Logic 2:  You(Player 1) will win the game if the number of stones in the bag is less than 4. 
                 * Because you can take out 1,2 or 3 stones in your first move */

                else if (n4 < 4)
                {
                    Console.WriteLine("You win the game. Your first move " + n4);
                }//end of else if

                /* Logic 3: You(Player 1) can win the game if the number of stones in the bag is more than 4. 
                 * In First move take out (n4 % 4) stones. Then player 2 picks up 1 or 2 or 3 stones. Repeat the same. 
                 * Player 2 will never win the game because no matter 1,2 or 3 stones he takes out, you will the one to take 
                 * out the last stone. */

                else
                {
                    Console.WriteLine("You can win the game. One Set of moves:");

                    int Player1, Player2;    // 2 integer variables to capture Player 1 and Player 2 moves
                    Random randNum = new Random(); // randNum will generate Player 2 moves

                    do // do loop will start and repeat while number of stones more than 4. Player 1 and Player 2 continue to play  
                    {
                        Player1 = (n4 % 4);    // Player 1 will take out (n4 % 4) stones
                        Player2 = randNum.Next(1, 4); // Player 2 will take out 1,2 or 3

                        Console.Write("{0},{1},", Player1, Player2); // prints Player 1 and Player 2 moves 

                        n4 = n4 - Player1 - Player2; // calculates remaining stones
                    } while (n4 > 4) ;

                        Player1 = n4; // last move by player 1 when number of stones less than 4
                        Console.WriteLine("{0}", Player1); // prints the last move by player 1

                }//end of else
            } // end of try
           catch
           {
               Console.WriteLine("Exception occured while computing Stones()");
           } // end of catch
       } // end of Stones    
    } // end of class
} // end of namespace


/* Self-reflection :-
 * 
 * Time taken:  Total - 12.5 hours
    PrintPattern(n): 1.5 hour
    PrintSeries(n2): 1 hour
    UsfTime(s): 2.5 hour
    UsfNumbers(n3, k): 2 hour
    PalindromePairs(words): 2.5 hour
    Stones(n4): 3 hour

   Learning:
    Operators: 
     •	Arithmetic Operators : +, -, *, /, %
     •	Relational Operators : ==, !=, >, < , >=, <= 
     •	Logical Operators : &&
     •	Assignment Operators :=,+=
    Data types: Integer, String, dateTime and Type conversion 
    conditional structures: If else statements
    iteration structures: while loop, do while loop, for loop
    Exception Handling: try, catch
    Arrays, Classes
    Fields(variables) and methods

   Recommendations: 
    Some more questions can be included in this 1st assignment. Overall very nice assignment as this covered many topics.  
    Some questions on Methods which will take user inputs with appropriate exception handling can be added which will make it interesting. 
    */
