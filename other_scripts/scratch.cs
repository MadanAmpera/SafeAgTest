using System;
using System.Collections.Generic;

public class User
{
    public string firstName = "First";
    public string lastName = "Last";
    public string email = "email@safeagsystems.com";
}

public class Program
{
    public static List<User> users = new List<User>(){
        new User(){firstName = "Bob", lastName = "Jones", email = "bobjones@hotmail.com"},
        new User(){firstName = "Bob", lastName = "Jones", email = "bobjones@hotmail.com"},
        new User(){firstName = "Bob", lastName = "Jones", email = "bobjones@hotmail.com"},
        new User(){firstName = "Bob", lastName = "Jones", email = "bobjones@hotmail.com"},
        new User(){firstName = "Bob", lastName = "Jones", email = "bobjones@hotmail.com"},
        new User(){firstName = "Bob", lastName = "Jones", email = "bobjones@hotmail.com"}

    };
    public static void Main()
    {
        
    }
}