using System.Linq;

class DeliveryDogManager
{
    private List<Dog> dogs;

    //Delivery dog manager constructor
    public DeliveryDogManager()
    {
        dogs = new List<Dog>();
    }

    //Create a new dog
    public void CreateDog(string name, int age, string location, string currentTask, string destination)
    {
        //Call the create dog method in the class Dog
        Dog newDog = Dog.CreateDog(name, age, location, currentTask, destination);
        dogs.Add(newDog);
        Console.WriteLine($"Name:{newDog.Name}");
        Console.WriteLine($"Age: {newDog.Age}");
        Console.WriteLine($"Location: {newDog.Location}");
        Console.WriteLine($"Current Task:{newDog.CurrentTask}");
        Console.WriteLine($"Destination:{newDog.Destination}");
    }
    //Get dog via name. Only finds first instance of dog
    public Dog getDogByName(string name)
    {
        return dogs.FirstOrDefault(p => p.Name == name);
    }

    //Update dog by name
    public void UpdateDogByName(string name, string newName, int newAge, string newLocation, string newCurrentTask, string newDestination)
    {
        //Call get dog by name method to select a specific dog
        Dog dog = getDogByName(name);
        if (dog != null)
        {
            dog.UpdateDogDetails(newName, newAge, newLocation, newCurrentTask, newDestination);
        }
    }
    public void DogHasArrivedAtDestination(string name, string newLocation, string NewDestination)
    {
        Dog dog = getDogByName(name);
            if (dog != null)
        {
            dog.UpdateDogDestination(newLocation, NewDestination);
        }

    }
    //Delete dog via name
    public string DeleteDogByName(string name)
    {
        //Get the dog by its name
        Dog dog = getDogByName(name);
        //Remove the specified dog from dogs
        if (dog != null)
        {
            dogs.Remove(dog);
        }
        return name;
    }
    //Return a list of all the dogs
    public List<Dog> GetAllDogs()
    {
        return dogs;
    }
}