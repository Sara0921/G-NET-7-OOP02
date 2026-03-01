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
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
