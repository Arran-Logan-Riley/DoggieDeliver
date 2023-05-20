class Dog{
    public string Name {get; set;}
    public int Age {get; set;}
    public string Location {get; set;}
    public string CurrentTask {get; set;}
    public string Destination {get; set;}

    //Class constructor
    public Dog(string name, int age, string location, string currentTask, string destination){
        Name = name;
        Age = age;
        Location = location;
        CurrentTask = currentTask;
        Destination = destination;
    }

    //Method to create new dog
    public static Dog CreateDog(string name, int age, string location, string currentTask, string destination){
        return new Dog(name, age, location, currentTask, destination);
    }

    //Method to Get dog details
    public void GetDogDetails(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"age: {Age}");
    }

    //Update dogs' information
    public void UpdateDogDetails(string name, int age, string location, string currentTask, string destination){
        Name = name;
        Age = age;
        Location = location;
        CurrentTask = currentTask;
        Destination = destination;

    }

    public void UpdateDogDestination(string newLocation, string newDestination){
        Location = newLocation;
        Destination = newDestination;
    }

}