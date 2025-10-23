using System;

namespace UserInfoApp
{
    


    // User Class
    
    class User
    {
        // private fields
        private string name;
        private int age;
        private string hobby;

        // constructor to init name and age
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method 1: Display name and age
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Method 2 (Overloaded): display name + age + hobby
        public void DisplayInfo(string hobby)
        {
            this.hobby = hobby;
            Console.WriteLine($"Name: {name}, Age: {age}, Hobby: {hobby}");
        }

        // Method 3 (Overloaded): display name + years until retirement
        public void DisplayInfo(int yearsToRetirement)
        {
            Console.WriteLine($"{name} will retire in {yearsToRetirement} years.");
        }

        // get age for retirement calculations
        public int GetAge()
        {
            return age;
        }
    }

    

    // Main Program
    
    class Program
    {
        static void Main(string[] args)
        {

            // input name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // input age
            Console.Write("Enter your age: ");
            int age;

            // TryParse for safety
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            User user = new User(name, age);

            user.DisplayInfo();

            // input hobby
            Console.Write("Enter your hobby: ");
            string hobby = Console.ReadLine();

            // display hobby
            user.DisplayInfo(hobby);

            // retirement calculator
            int retirementAge = 65;
            int yearsLeft = retirementAge - user.GetAge();
            if (yearsLeft < 0)
                yearsLeft = 0;

            user.DisplayInfo(yearsLeft);
        }
    }
}
