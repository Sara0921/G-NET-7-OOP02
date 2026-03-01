namespace Assignment_2
{
    #region Part 01
    #region Question01
    //a) 1. Owner is public field .t can be freely changed from outside the class with no control.
    //  2.Balance is public field.  anything can directly modify it by passing any validation logic.
    //b) Make both fields private and expose them through properties or methods. 
    //public class BankAccount
    //{
    //    private string _owner;
    //    private double _balance;

    //    public string Owner { get; set; }
    //    public double Balance { get; set; }

    //}
    // c)Exposing fields directly removes the class's ability to protect its own data.
    // Any external code can set Balance to a negative number or zero out Owner without the object knowing or being able to react.
    // Encapsulation exists so the object controls its own state 
    #endregion
    #region Question02
    //>>A field is a plain variable stored directly in the class. A property is a controlled access point to data, using get/set accessors 
    //>>Yes, a property can contain logic — validation, calculations, formatting, anything.
    //>>Example of a read-only calculated property
    //public class Circle
    //{
    //    private double _radius;

    //    public double Radius { get { return _radius; } set { _radius = value; } }

    //    public double Area
    //    { get { return _radius * _radius * Math.PI; } 
    //}
    #endregion
    #region Question03
    //a) It's called an Indexer.>>It lets you access an object using square bracket syntax (register[0]) just like an array
    //b)it causes an IndexOutOfRangeException because the array only has 5 slots
    //>> to make it safer add a bound check
    //public class StudentRegister
    //{
    //    private string[] names = new string[5];
    //    public string this[int index]
    //    { get { return names[index]; }
    //        set
    //        {
    //            if (index >= 0 && index < names.Length) //bound check
    //                names[index] = value;
    //            else
    //                Console.WriteLine("Index out of Range");
    //        } }
    //}
    //c) Yes, a class can have multiple indexers, as long as they have different parameter types (overloading).
    // a class that lets you access students by number OR by name:
    //public string this[int index]
    //{
    //    get { return names[index]; }
    //}

    //public int this[string name]
    //{
    //    get { return Array.IndexOf(names, name); } 
    //}
    #endregion
    #region Question04
    //a) static on TotalOrders:TotalOrders belongs to the class itself — one shared copy for everyone.Every time a new Order object is created, the same TotalOrders increments.
    // Item is an instance field — each object has its own separate value
    //b) No — a static method cannot access Item directly.
    //Item belongs to a specific object. A static method has no this, so it doesn't know which object's Item to access
    #endregion
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
