using System;

class Program
{
    static void Main(string[] args)
    {
        int result = Test.Run();
        BACILHelpers.BACILConsole.Write("Returned "); 
        BACILHelpers.BACILConsole.Write(result); 
        BACILHelpers.BACILConsole.Write("\n"); 
    }
}