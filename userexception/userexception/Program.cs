using System;
public class InvalidAgeException : Exception{
    public InvalidAgeException(String message)
        : base(message)
    {

    }
}
public class TestUserDefinedException{
    static void validate(int age){
        if (age < 18){
            throw new InvalidAgeException("Sorry, Age must be greater than 18 to vote");
        }
        else Console.WriteLine("yes! you vcan vote");
    }
    public static void Main(string[] args) {

        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        try{
            validate(age);
        }
        catch (InvalidAgeException e) { Console.WriteLine(e); }
        Console.ReadKey();
    }
}