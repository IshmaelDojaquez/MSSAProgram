using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TicTacToe
{
    class Program

    {

        //This array is used to mark the different positions on the board
        static char[] position = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //These variable stores the users placement of their X
        static int player1choice;
        static int player2choice;
        //Variable to determine win
        static bool? win;


        static void Main(string[] args)
        {
            Rules();

            do
            {
                //Whenever the game begins... clear the board  
                Console.Clear();

                //Creating the board
                Board();

                //Playing portion
                //Player1 turn
                player1choice = int.Parse(Console.ReadLine());
                //Checking to see if there is already a X or O in that position
                if (position[player1choice] != 'X' && position[player1choice] != 'O')
                {
                    position[player1choice] = 'X';
                }
                else
                {
                    Console.WriteLine("\nThere is already a marker there. Choose again:");
                    player1choice = int.Parse(Console.ReadLine());
                    if (position[player1choice] != 'X' && position[player1choice] != 'O')
                    {
                        position[player1choice] = 'X';
                    }
                }

                Console.Clear();
                Board();
                //Checking for win
                win = CheckWin();
                if(win != false)
                {
                    WinnerMessage1();
                }

                //Player2 turn
                player2choice = int.Parse(Console.ReadLine());
                //Player2 turn
                if (position[player2choice] != 'X' && position[player2choice] != 'O')
                {
                    position[player2choice] = 'O';
                }
                else
                {
                    Console.WriteLine("\nThere is already a marker there. Choose again:");
                    player2choice = int.Parse(Console.ReadLine());
                    if (position[player2choice] != 'X' && position[player2choice] != 'O')
                    {
                        position[player2choice] = 'O';
                    }
                }
                Console.Clear();
                Board();
                win = CheckWin();
                if (win != false)
                {
                    WinnerMessage2();
                }
            } while (win == false);
        }

        private static void WinnerMessage2()
        {
            Console.WriteLine("Player2 has won!");
        }

        private static void WinnerMessage1()
        {
            Console.WriteLine("Player1 has won!");
        }

        private static void Rules()
        {
            Console.WriteLine("The rules are simple.. Chose a number between 1-9 to place down your marker!");
            Console.WriteLine("\nPress 0 to begin");
            int starter = int.Parse(Console.ReadLine());
        }

        //Creating Board Method
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", position[1], position[2], position[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", position[4], position[5], position[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", position[7], position[8], position[9]);
            Console.WriteLine("     |     |      ");
        }

        //Checking for Win
        private static bool? CheckWin()
        {
            //Checking Win by Rows
            //First Row
            if (position[1] == position[2] && position[2] == position[3])
            {
                return true;
            }
            //Second Row 
            else if (position[4] == position[5] && position[5] == position[6])
            {
                return true;
            }
            //Third Row
            else if (position[6] == position[7] && position[7] == position[8])
            {
                return true;
            }
            //Checking Win by Columns
            //First Column 
            else if (position[1] == position[4] && position[4] == position[7])
            {
                return true;
            }
            //Second Column
            else if (position[2] == position[5] && position[5] == position[8])
            {
                return true;
            }
            //Third Column 
            else if (position[3] == position[6] && position[6] == position[9])
            {
                return true;
            }
            //Checking Win by Diagnols                      
            else if (position[1] == position[5] && position[5] == position[9])
            {
                return true;
            }
            else if (position[3] == position[5] && position[5] == position[7])
            {
                return true;
            }
            else if (position[1] == position[2] && position[2] == position[3] && position[3] == position[4] && position[4] == position[5] && position[5] != position[6] && position[6] != position[7] && position[7] != position[8] && position[8] != position[9])
            {
                return null;
            }
            else
            {
                return false;
            }
        }
    }
}
