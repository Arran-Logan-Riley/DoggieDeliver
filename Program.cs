class Program
{
    static DeliveryDogManager dogManager = new DeliveryDogManager();

    static void Main(string[] args)
    {
        dogManager.CreateDog("Sam", 5, "Behind the trash can, addington KFC", "Getting a new package", "Kaikoura");
        dogManager.CreateDog("Jammie",  6, "New Brighton", "Packing package at beach", "Sumner Beach");

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("What would you like to do?\n1. Add a new dog\n2. Read database\n3. Update a dog\n4. Dog has arrived at a destination \n5. Delete a dog\n6. Exit");
            string userAnswer = Console.ReadLine();
            CheckAnswer(userAnswer, ref isRunning);
        }
    }

    static void CheckAnswer(string userAnswer, ref bool isRunning)
    {
        switch (userAnswer.ToLower())
        {
            case "add a new dog":
                Console.WriteLine("Please specify a name:");
                string name = Console.ReadLine();

                Console.WriteLine("Please specify an Age:");
                string ageString = Console.ReadLine();

                Console.WriteLine("Please specify the dog's location:");
                string location = Console.ReadLine();

                Console.WriteLine("Please specify a current task:");
                string currentTask = Console.ReadLine();

                Console.WriteLine("Please specify a destination:");
                string destination = Console.ReadLine();


                if (int.TryParse(ageString, out int age))
                {
                    dogManager.CreateDog(name, age, location, currentTask, destination);
                    Console.WriteLine("Dog added successfully");
                }
                else
                {
                    Console.WriteLine("Input Error");
                }
                break;

            case "read database":
                List<Dog> dogs = dogManager.GetAllDogs();
                foreach (Dog dog in dogs)
                {
                    Console.WriteLine($"Name:{dog.Name}");
                    Console.WriteLine($"Age: {dog.Age}");
                    Console.WriteLine($"Location: {dog.Location}");
                    Console.WriteLine($"Current Task:{dog.CurrentTask}");
                    Console.WriteLine($"Destination:{dog.Destination}");
                }
                break;

            case "update a dog":
                Console.WriteLine("What is the name of your dog?");
                string nameQuery = Console.ReadLine();
                Console.WriteLine("What is the dog's new name?");
                string newName = Console.ReadLine();
                Console.WriteLine("How old is the dog?");
                string newAge = Console.ReadLine();
                Console.WriteLine("What is the location of the dog");
                string newLocation = Console.ReadLine();
                Console.WriteLine("What is the task of the dog");
                string newCurrentTask = Console.ReadLine();
                Console.WriteLine("What is the destination of the dog");
                string newDestination = Console.ReadLine();

                if (int.TryParse(newAge, out int updatedAge))
                {
                    dogManager.UpdateDogByName(nameQuery, newName, updatedAge, newLocation, newCurrentTask, newDestination);
                    Console.WriteLine("Dog Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Input Error");
                }
                break;

            case "dog has arrived at a destination":
                Console.WriteLine("What is the name of the dog?");
                name = Console.ReadLine();
                Console.WriteLine("What is the new location of the dog?");
                newLocation = Console.ReadLine();
                Console.WriteLine("What is the new destination of the dog?");
                newDestination = Console.ReadLine();
                dogManager.DogHasArrivedAtDestination(name, newLocation, newDestination);
                break;

            case "delete a dog":
                Console.WriteLine("What is the name of the dog you want to delete from the database?");
                string nameToDelete = Console.ReadLine();
                string nameOfDeletedDog  = dogManager.DeleteDogByName(nameToDelete);
                Console.WriteLine($"Deletion of {nameOfDeletedDog}");
                break;

            case "exit":
                isRunning = false;
                break;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}
