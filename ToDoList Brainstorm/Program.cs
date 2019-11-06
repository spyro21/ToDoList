using System;

namespace ToDoList_Brainstorm
{
    class Program
    {
        public string actionA;


        static void Main(string[] args)
        {
           string[] toDoList = new string[0];
            Array.Resize(ref toDoList, toDoList.Length + 2);
            toDoList[0] = "egg moment";
            toDoList[1] = "nice";
            actionQ(toDoList);
        }
       
        public static void actionQ(string[] arr) {
            

            string actionA;
           

            listItems(arr);
            Console.WriteLine("add or check?");
            actionA = Console.ReadLine();

            if (actionA == "add") {
                Console.WriteLine("you chose add");
                Console.WriteLine("what is the name of item?");

                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = Console.ReadLine();
            } else if (actionA == "check")
            {
                Console.WriteLine("which item do you want to check off");
            }
            
            actionQ(arr);
        }

        public static void listItems(string[] arr) {

            Console.WriteLine("\nTo Do: ");

            for (int i = 0; i < arr.Length;i++) {
                Console.WriteLine((i + 1) + ".  " + arr[i]);
            }
            Console.WriteLine();
        } 
    }
}
