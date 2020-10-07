using System;

/// Week 6		Lab 2
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  October 5th 2020

namespace Homework_6 {

    //counter class
    class Counter {

        //instance variables
        private int count = 0;

        //get count
        public int GetCount() {
            return count;
        }

        //set count to 0
        public void ResetCounter() {
            count = 0;
        }

        //display count to screen
        public String DisplayCount() {
            return "The counter is at " + count;
        }

        //add one
        public void AddOne() {
            count += 1;
        }

        //subtract one
        public void SubtractOne() {

            //check if below 0
            if ((count - 1) >= 0) {
                count -= 1;
            } else {
                Console.WriteLine("Counter cannot go below 0");
            }

        }

        //ToString and Equals
        public override String ToString() {
            return "Count: " + count;
        }

        public bool Equals(Counter other) {
            return count == other.count;
        }

    }

    class Program {
        static void Main(string[] args) {

            //create counter and exit variables
            Counter counter = new Counter();
            Counter secondCounter = new Counter();
            bool exited = false;

            //test get, to string and equals methods
            Console.WriteLine(counter.GetCount());
            Console.WriteLine(counter.ToString());
            Console.WriteLine(counter.Equals(secondCounter));

            //menu
            Console.WriteLine("Type reset, add, subtract, show or exit");

            //loop through menu until exit
            do {
                //get user input
                String answer = Console.ReadLine();

                //detect what user asked
                switch (answer) {

                    case "reset":
                        counter.ResetCounter();
                        Console.WriteLine(counter.DisplayCount());
                        break;

                    case "add":
                        counter.AddOne();
                        Console.WriteLine(counter.DisplayCount());
                        break;

                    case "subtract":
                        counter.SubtractOne();
                        Console.WriteLine(counter.DisplayCount());
                        break;

                    case "show":
                        Console.WriteLine(counter.DisplayCount());
                        break;

                    case "exit":
                        exited = true;
                        Console.WriteLine("Exiting");
                        break;

                    default:
                        Console.WriteLine("Command not recognized");
                        break;

                }

                //check if need to display menu again
                if (!exited) {
                    Console.WriteLine("Type reset, add, subtract, show or exit");
                }


            } while (!exited);

        }
    }
}
