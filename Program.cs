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
            var playingRPS = true;
            while (playingRPS) {
                System.Console.WriteLine("What do you Choose? R/P/S");
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
                                    Scissors!");
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
                             Cpu Chose
    _______                      _______
---'   ____)____             ---'   ____)
           ______)                (_____)
        __________)               (_____)
       (____)                     (____)
---.__(___)                 ---.__(___)
                              Rock!");
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
                System.Console.WriteLine("Wanna Play Again? Y/n");
                var endChoice = Console.ReadKey();
                if (endChoice.Key != ConsoleKey.Y){
                    playingRPS = false;
                }
            }
        }
    }
}
