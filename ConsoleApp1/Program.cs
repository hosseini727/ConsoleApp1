using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parent myParent = new Parent("Message from parent.");
            Child myChild = new Child("Message from child.");

            myParent.ShowMessage();

            myChild.ShowMessage();

            myParent.Message = "Modified message of the parent.";
            myParent.ShowMessage();

            myChild.Message = "Modified message of the child.";
            myChild.ShowMessage();

        }
    }



    class Parent
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public void ShowMessage()
        {
            Console.WriteLine(message);
        }

        public Parent(string message)
        {
            this.message = message;
        }
    }

    class Child : Parent
    {
        public Child(string message) : base(message)
        {

        }
    }
}
