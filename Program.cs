class Program{
    static DeliveryDogManager dogManager = new DeliveryDogManager();

    static void Main(string[] args){
        dogManager.CreateDog("Sam", 5);
        dogManager.CreateDog("Jammie", 6);

        Console.WriteLine("What would you like to do? \n 1. ddd a new dog \n 2. read database \n 3. update a dog \n 4. delete a dog \n 5. exit");
        string userAnswer = Console.ReadLine();
        CheckAnswer(userAnswer);
    }
    static void CheckAnswer(string userAnswer){
        if(userAnswer == "add a new dog"){
            Console.WriteLine("Please specify a name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please specify an Age:");
            string ageString = Console.ReadLine();

            //Try to parse the stirng to an int
            if(int.TryParse(ageString, out int age)){
                dogManager.CreateDog(name, age);
                Console.WriteLine("Dog added successfully");
            }else{
                Console.WriteLine("Input Error");
            }
        }else if(userAnswer == "read database"){
            List<Dog> dogs = dogManager.GetAllDogs();
            for(int i = 0; i < dogs.Count; i++){
                Console.WriteLine(dogs[i].Name);
                Console.WriteLine(dogs[i].Age);
            }
        }else if(userAnswer == "update a dog"){
            Console.WriteLine("What is the name of your dog?");
            string nameQuery = Console.ReadLine();
            Console.WriteLine("What is dogs' new name?");
            string newName = Console.ReadLine();
            Console.WriteLine("How old is the dog?");
            string newAge = Console.ReadLine();

            if(int.TryParse(newAge, out int age)){
                dogManager.UpdateDogByName(nameQuery, newName, age);
                Console.WriteLine("Dog Updated Successfully");
            }else{
                Console.WriteLine("Input Error");
            }
            
        }else if(userAnswer == "delete a dog"){
            Console.WriteLine("What is the name of the dog you wnat to delete from the database?");
            string nameQuery = Console.ReadLine();
            dogManager.DeleteDogByName(nameQuery);
        }
    }
}