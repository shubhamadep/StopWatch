using System;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            Boolean stopWatchState = true;
            var stopWatch = new StopWatchFunctions();

            Console.WriteLine("Welcome to Stop Watch : \n");

            Console.WriteLine("Press any key + enter to begin.. \n Press x + enter to end \n");

            while(true)
            {
                var input = Console.ReadLine();

                if(input == "x" || input == "X"){
                    break;
                }
                else
                {
                    //sending reference of the variable to keep consistent state.
                    stopWatch.ChangeState(ref stopWatchState);
                }
            }

            Console.WriteLine("Thank you for using Stop Watch. \n");
        }
    }
}

