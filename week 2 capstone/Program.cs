using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Task Manager!");
            string response = "y";

            List<Task> tasks = new List<Task>();
            while (response == "y")
            {


                Console.WriteLine("1: List Task ");
                Console.WriteLine("2: Add Task");
                Console.WriteLine("3: Delete Task");
                Console.WriteLine("4: Mark Task Complete");
                Console.WriteLine("5: Quit ");

                Console.WriteLine("Please Select an option from the menu!");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        foreach (Task task in tasks)
                        {
                            foreach (string member in task.members)
                            {
                                Console.WriteLine(member);
                            }
                            Console.WriteLine(task.date);
                            Console.WriteLine(task.status);
                            Console.WriteLine(task.description);

                        }
                        break;
                    case "2":
                        string newmember = "1";
                        Task newtask = new Task();
                        while (newmember != "")
                        {
                            Console.WriteLine("Add a (member) or press (enter) to exit! ");
                            newmember = Console.ReadLine();
                            newtask.members.Add(newmember);
                        }
                        Console.WriteLine("Please enter a date ");
                        newtask.date = Console.ReadLine();
                        Console.WriteLine("Please enter a description");
                        newtask.description = Console.ReadLine();
                        tasks.Add(newtask);
                        break;
                    case "3":

                        
                        if (tasks.Remove(GetTask(tasks, "What task would you like to delete ")))
                        {
                            Console.WriteLine(" Task has been removed ");
                        }
                        else
                        {
                            Console.WriteLine(" The task wasn't found ");
                        }

                        break;
                    case "4":
                        Console.WriteLine("What task have you completed");
                        int index = int.Parse(Console.ReadLine());
                        index--;
                        tasks[index].status = true;
                        break;
                    case "5":
                        response = "n";
                        break;

                }

                if ( response != "y")
                {
                    Console.WriteLine("Would you like to continue (y/n) ");
                    response = Console.ReadLine();
                }
                
            }
        }

        public static Task GetTask(List<Task> list, string message)
        {
            Console.WriteLine(message);
            int deletion = int.Parse(Console.ReadLine());
            deletion--;

            return list[deletion];
        }

    }
}
