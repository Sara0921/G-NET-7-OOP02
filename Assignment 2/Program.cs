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
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
