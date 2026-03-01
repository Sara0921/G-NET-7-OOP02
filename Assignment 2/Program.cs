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
    #region Part 02
    //enum TicketType
    //{
    //    Standard,
    //    VIP,
    //    IMAX

    //}
    //struct Seat
    //{
    //    public char Row;
    //    public int Number;

    //    public Seat(char row, int number)
    //    {
    //        Row = row;
    //        Number = number;
    //    }

    //    public override string ToString() => $"{Row}{Number}";

    //}
    //class Ticket
    //{
    //    public string _movieName;
    //    public TicketType _type;
    //    public Seat _seat;
    //    private double _price;
    //    //2.a
    //    private static int ticketCounter = 0;
    //    //2.b
    //    public int Ticketid { get; private set; }

    //    //1
    //    //1.a)
    //    public string MovieName
    //    {
    //        get { return _movieName; }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //                _movieName = value;

    //        }
    //    }
    //    //1.a)
    //    public TicketType Type
    //    {
    //        get { return _type; }
    //        set { _type = value; }
    //    }
    //    //1.a)
    //    public Seat Seat
    //    {
    //        get { return _seat; }
    //        set { _seat = value; }
    //    }
    //    //1.a)
    //    public double Price
    //    {
    //        get { return _price; }
    //        set
    //        {
    //            if (value > 0)
    //                _price = value;
    //        }
    //    }
    //    //1.b)
    //    public double PriceAfterTax
    //        => _price + (_price * 14.0 / 100);



    //    public Ticket(string movieName, TicketType type, Seat seat, double price)
    //    {
    //        MovieName = movieName;
    //        Type = type;
    //        Seat = seat;
    //        Price = price;
    //        //2.b
    //        ticketCounter++;
    //        Ticketid = ticketCounter;
    //    }
    //    public Ticket(string movieName) : this(movieName, TicketType.Standard, new Seat('A', 1), 50) { }
    //    //2.c
    //    public static int GetTotalTicketsSold()
    //        => ticketCounter;

    //    public double CalcTotal(double taxPercent)
    //    { return Price + (Price * taxPercent / 100); }



    //    public void ApplyDiscount(ref double discountAmount)
    //    {
    //        if (discountAmount > 0 && discountAmount <= Price)
    //        {
    //            Price -= discountAmount;
    //            discountAmount = 0;

    //        }
    //    }

    //    public void PrintTicket(double taxPercent)
    //    {
    //        Console.WriteLine($"Movie : {MovieName}");
    //        Console.WriteLine($"Type : {Type}");
    //        Console.WriteLine($"Seat : {Seat}");
    //        Console.WriteLine($"Price : {Price}");
    //        Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent)}");



    //    }


    //}
    ////3
    //class Cinema
    //{
    //    private Ticket[] tickets = new Ticket[20];
    //    //3.a
    //    public Ticket this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index >= tickets.Length)
    //                return null;
    //            return tickets[index];
              
    //        }
    //        set {

    //            if (index < 0 || index >= tickets.Length)
    //                return ;
    //            tickets[index] = value;


    //        }

    //    }
    //    //2.b
    //    public Ticket this[string movieName]
    //    {
    //        get {
    //            foreach (Ticket t in tickets)
    //            { 
    //                if(t!=null && t.MovieName == movieName)
    //                    return t;
                
    //            }
    //            return null;
    //        }

    //    }
    //    //3.c
    //    public bool AddTicket(Ticket t)
    //    { 
    //        for (int i = 0; i < tickets.Length; i++)
    //        {
    //            if(tickets[i] == null)
    //            {
    //                tickets[i] = t;
    //                return true;
    //            }
    //        }
    //        return false;
    //        {

    //        }
    //    }
    //}

    ////4
    //static class BookingHelper
    //{
    //    //4.b
    //    private static int counter = 0;
    //    //4.a
    //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    //    {
    //        double total = numberOfTickets * pricePerTicket;
    //        if (numberOfTickets > 5)
    //        { 
    //            return total - (total * 10.0/100);
    //        }
    //        return total;
    //    }
    //    //4.b
    //    public static string GenerateBookingReference()
    //    {
    //        counter++;
    //        return $"BK-{counter}";
    //    }


    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part02
            ////5
            //Cinema cinma = new Cinema();
            //Console.WriteLine("========== Ticket Booking ==========\n");
            ////5.a
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data for Ticket {i+1}");

            //    Console.Write("Movie Name : ");
            //    string moviename = Console.ReadLine();

            //    Console.Write("Ticket Type (0=Standard , 1=VIP , 2=IMAX) : ");
            //    int tickettype = int.Parse(Console.ReadLine());
            //    TicketType type = (TicketType)tickettype;

            //    Console.Write("Seat Row (A-Z): ");
            //    char row = Console.ReadLine().ToUpper()[0];

            //    Console.Write("Seat Number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    Ticket t = new(moviename, type, new(row, number), price);

            //    cinma.AddTicket(t);

            //    Console.WriteLine();


            //}
            ////5.b
            //Console.WriteLine("========== All Tickets ==========");
            //for (int i = 0; i < 3; i++)
            //{
            //    Ticket t = cinma[i];
            //    Console.WriteLine($"Ticket #{t.Ticketid} | {t.MovieName} | {t.Type} | " +
            //              $"Seat: {t.Seat} | Price: {t.Price} EGP | " +
            //              $"After Tax: {t.PriceAfterTax} EGP");

            //}

            ////5.c
            //Console.WriteLine("\n========== Search by Movie ==========");
            //Console.Write("Enter movie name to search: ");
            //string search = Console.ReadLine();

            //Ticket found = cinma[search];
            //if (found != null)
            //{
            //    Console.WriteLine($"Found: Ticket #{found.Ticketid} | {found.MovieName} | " +
            //              $"{found.Type} | Seat: {found.Seat} | Price: {found.Price} EGP");
            //}
            //else
            //{ 
            //    Console.WriteLine("Not found.");
            //}

            ////5.d
            //Console.WriteLine("\n========== Statistics ==========");
            //Console.WriteLine($"Total Tickests Sold : {Ticket.GetTotalTicketsSold()}");
            //Console.WriteLine();
            ////5.e
            //Console.WriteLine($"Booking Reference 1:{BookingHelper.GenerateBookingReference()}");
            //Console.WriteLine($"Booking Reference 2:{BookingHelper.GenerateBookingReference()}");
            //Console.WriteLine();

            ////5.f
            //double GroupTotal = BookingHelper.CalcGroupDiscount(5, 80);
            //Console.WriteLine($"Group Discount (5 tickets x 80 EGP): {GroupTotal} EGP (10% off applied)");

            #endregion
        }
    }
}
