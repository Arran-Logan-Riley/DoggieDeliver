class Dog{
    public string Name {get; set;}
    public int Age {get; set;}

    //Class constructor
    public Dog(string name, int age){
        Name = name;
        Age = age;
    }

    //Method to create new dog
    public static Dog CreateDog(string name, int age){
        return new Dog(name, age);
    }

    //Method to Get dog details
    public void GetDogDetails(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"age: {Age}");
    }

    //Update dogs' information
    public void UpdateDogDetails(string name, int age){
        Name = name;
        Age = age;
    }


}