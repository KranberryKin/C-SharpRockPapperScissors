using System;
using CpuChoice;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            What we need:
                Random number generator from one to 3
                a switch statement that chooses the computers choice(rock, papper, scissors)
                A statement that the user is allow to choose
                A function that compares the users choice with the cpu choice and declares winner.
            */
            var comWin = 0;
            var playerWin = 0;
            var playingRPS = true;
            while (playingRPS) {
                System.Console.WriteLine("\n What do you Choose? \n Press 'R' for Rock \n Press 'P' for Papper \n Press 'S' for Scissors");
                var CpuChoice = new play().shoot();
                var choice = Console.ReadKey();
                switch (choice.Key) {
                    case ConsoleKey.R : {
                        if (CpuChoice == ConsoleKey.P){
                            System.Console.WriteLine(@"
                        You Lose!
    You Chose Rock!                 Cpu Chose
        _______                       _______
    ---'   ____)                   ---'   ____)____
          (_____)                             ______)
          (_____)                             _______)
          (____)                             _______)
    ---.__(___)                   ---.__________)
                                       Papper!");
                            comWin += 1;
                            break;
                        }
                        if (CpuChoice == ConsoleKey.S){
                            System.Console.WriteLine(@"
                      You Win!
    You Chose Rock!             Cpu Chose
        _______                       _______
    ---'   ____)                  ---'   ____)____
          (_____)                           ______)
          (_____)                        __________)
          (____)                        (____)
    ---.__(___)                   ---.__(___)
                                    Scissors!");
                                    playerWin += 1;
                            break;
                        }
                        if (CpuChoice == ConsoleKey.R){
                            System.Console.WriteLine(@"
                     You Tie!
    You Chose Rock!             Cpu Chose
        _______                           _______   
    ---'   ____)                      ---'   ____)  
          (_____)                           (_____) 
          (_____)                           (_____) 
          (____)                            (____)  
    ---.__(___)                       ---.__(___)   
                                    Rock!");
                            break;
                        }
                        System.Console.WriteLine(ConsoleKey.R);
                        System.Console.WriteLine(CpuChoice);
                    break;
                    }
                    case ConsoleKey.P : {
                        if (CpuChoice == ConsoleKey.S){
                            System.Console.WriteLine(@"
                    You Lose!
        You Chose Papper!             Cpu Chose
     _______                              _______
  ---'   ____)____                    ---'   ____)____
             ______)                             ______)
             _______)                         __________)
            _______)                         (____)
 ---.__________)                      ---.__(___)
                                     Scissors!");
                            comWin += 1;
                            break;
                        }
                        if (CpuChoice == ConsoleKey.R){
                            System.Console.WriteLine(@"
                            You Win!
        You Chose Papper!                Cpu Chose
     _______                          _______
  ---'   ____)____                ---'   ____)
             ______)                    (_____)
             _______)                   (_____)
            _______)                    (____)
 ---.__________)                  ---.__(___)
                                      Rock!");
                                    playerWin += 1;
                            break;
                        }
                        if (CpuChoice == ConsoleKey.P){
                            System.Console.WriteLine(@"
                         You Tie!
        You Chose Papper!             Cpu Chose
     _______                    _______               
  ---'   ____)____           ---'   ____)____         
             ______)                    ______)       
             _______)                   _______)      
            _______)                   _______)       
 ---.__________)            ---.__________)           
                                Papper!");
                            break;
                        }
                        System.Console.WriteLine(ConsoleKey.P);
                        System.Console.WriteLine(CpuChoice);
                    break;
                    }
                    case ConsoleKey.S : {
                        if (CpuChoice == ConsoleKey.R){
                            System.Console.WriteLine(@"
                            You Lose!
    You Chose Scissors!                         Cpu Chose
    _______                      _______
---'   ____)____             ---'   ____)
           ______)                (_____)
        __________)               (_____)
       (____)                     (____)
---.__(___)                 ---.__(___)
                              Rock!");
                            comWin += 1;
                            break;
                        }
                        if (CpuChoice == ConsoleKey.P){
                            System.Console.WriteLine(@"
                            You Win!
    You Chose Scissors!                 Cpu Chose
    _______                                     _______
---'   ____)____                            ---'   ____)____
           ______)                                    ______)
        __________)                                   _______)
       (____)                                        _______)
---.__(___)                               ---.__________)
                                      Papper!");
                                    playerWin += 1;
                            break;
                        }
                        if (CpuChoice == ConsoleKey.S){
                            System.Console.WriteLine(@"
                        You Tie!
    You Chose Scissors!             Cpu Chose
    _______                         _______
---'   ____)____                ---'   ____)____
          ______)                         ______)
       __________)                     __________)
      (____)                          (____)
---.__(___)                     ---.__(___)
                                 Scissors");
                        }
                        System.Console.WriteLine(ConsoleKey.S);
                        System.Console.WriteLine(CpuChoice);
                    break;
                    }
                    default: {
                     break;
                    }
                }
                System.Console.WriteLine("\n Wanna Play Again? \n Press 'Y' for Yes \n Press 'N' for no");
                var endChoice = Console.ReadKey();
                if (endChoice.Key != ConsoleKey.Y){
                    playingRPS = false;
                    System.Console.WriteLine("\n Score Board \n You Won :" + playerWin + "\n Cpu Won :" + comWin);
                }
            }
        }
    }
}
