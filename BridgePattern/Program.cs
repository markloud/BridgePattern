using System;

class BridgePattern
{
    // Shows an abstraction and two implementations proceeding independently
    interface Bridge
    {
        string OperationImp();
    }

    class Abstraction
    {
        Bridge bridge;
        public Abstraction(Bridge implementation)
        {
            bridge = implementation;
        }
        public string Operation() // calls the actual operation based on Bridge implementation
        {
            return "Abstraction" + " <<< BRIDGE >>>> " + bridge.OperationImp();
        }
    }

    class ImplementationA : Bridge
    {
        public string OperationImp()
        {
            return "ImplementationA";
        }
    }

    class ImplementationB : Bridge
    {
        public string OperationImp()
        {
            return "ImplementationB";
        }
    }

    static void Main()
    {
        Console.WriteLine("Bridge Pattern\n");
        Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
        Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

        Console.ReadKey();
    }
}
/* Output
Bridge Pattern

Abstraction <<< BRIDGE >>>> ImplementationA
Abstraction <<< BRIDGE >>>> ImplementationB
*/
