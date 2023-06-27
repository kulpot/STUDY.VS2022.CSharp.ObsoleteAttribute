using System;

//ref link:https://www.youtube.com/watch?v=09qw2NBsDOk&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=11
// Obsolete attribute -- usefull in API change...use in dll for publishing code 

class MeAwesomeClass
{
    [Obsolete] // warning
    //[Obsolete(@"Hey, I found a better way to design this API. Please see my new" +
    //     " API for a better approach")] // warning with string
    //[Obsolete(@"Hey, I found a better way to design this API. Please see my new" +
    //    " API for a better approach", true)] // error bool true -- not allowed
    public static void MeFirstAttemptAtAnAwesomeAlgorithm()
    {
        Console.WriteLine("Some awesome code");
    }
}

class MainClass
{
    
    static void Main()
    {
        MeAwesomeClass.MeFirstAttemptAtAnAwesomeAlgorithm();
    }
}