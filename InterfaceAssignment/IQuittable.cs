using System;

namespace InterfaceAssignment
{
    // This is the IQuittable interface
    // Interfaces define a contract that classes must follow
    interface IQuittable
    {
        // This is the Quit method signature
        // Any class that implements IQuittable must have a Quit method
        void Quit();
    }
}
