using System.Linq;

class DeliveryDogManager {
    private List<Dog> dogs;

    //Delivery dog manager constructor
    public DeliveryDogManager(){
        dogs = new List<Dog>();
    }

    //Create a new dog
    public void CreateDog(string name, int age){
        //Call the create dog method in the class Dog
        Dog newDog = Dog.CreateDog(name, age);
        dogs.Add(newDog);
        Console.WriteLine(newDog.Name);
        Console.WriteLine(newDog.Age);
    }
    //Get dog via name. Only finds first instance of dog
    public Dog getDogByName(string name){
        return dogs.FirstOrDefault(p => p.Name == name);
    }

    //Update person by name
    public void UpdateDogByName(string name, string newName, int newAge){
        //Call get dog by name method to select a specific dog
        Dog dog = getDogByName(name);
        if(dog != null){
            dog.UpdateDogDetails(newName, newAge);
        }
    }
    //Delete dog via name
    public void DeleteDogByName(string name){
        //Get the dog by its name
        Dog dog = getDogByName(name);
        //Remove the specified dog from dogs
        if(dog != null){
            dogs.Remove(dog);
        }
    }
    //Return a list of all the dogs
    public List<Dog> GetAllDogs(){
        return dogs;
    }
}