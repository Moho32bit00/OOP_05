namespace Session05_oop_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1 Object Copying
            /*
            a) the assigned object takes the same address as the other object .
            b) no it does not , because they have the same address looking at the same data in the heap .
            c) copying object does mean you copy the other object data depending on the copy method (shallow or deep )
            , while copying it's reference does mean u get the same address so now u r looking at the data as the other object .
            */
            #endregion
            #region Q2 Shallow Copy vs Deep Copy
            /*
            a) it is a way to create a new object and copy all the vlaue type fields of another object to it , and for the reference value type it does copy the address  .
            b) it is a way to crreate a new oblect and copy all the data inside other object including the nested objects .
            c) the shallow copy does the take the address and it does now look at the same thing as the other original object .
            d) the deep copy does create a new object for this reference-type member and insert the original object value in this object so now it is independant object .
            e) if u have a nested object inside your object let's say for ex address and u want to copy everything but u want it to independant so u can make changes on the address without 
            affecting the original object address .
            */
            #endregion
            #region Q3 Static Members
            /*
            a) static field is a feild belong to the class itself , the instance field is created everytime a new object is created  while the static is one shared copy stored in the memory for the whole program .
            b) it is a method that belong to the class u can not call it using object u must use the class to call it , no it can not .
            c)  it is a constructor that run before anything to perform a certain act only once , it does excecute first thing on the program only one time 
            d) is a class that only have  static methods and static fields , no u can not create object using it .
            */
            #endregion
            #region Q4 Extension Methods
            /*
            a) it is a static method used to extend other class Extension without changing anything in that class .
            b) this
            c) in another static class it perfered to be a helper class 
            d) no it can not access private members .
            */
            #endregion
            #region Q5 Partial Classes and Partial Methods
            /*
            a) partial class is dividing one class into multiple files all of them are combined by the compiler .
            b) to organize large class across multiple files .
            c) it is a method that have no implementation and it can be implemented in any other part .
            d) if it does have access modifier you must implemented on another part , if it does not have access modifier it become optional method u can implement it if u want .
            */
            #endregion
            #endregion



            #region 11 Main() Checklist
                // 1. Create and use DeliveryUtilities
                DeliveryUtilities.PrintSystemTitle();
                DeliveryUtilities.PrintSeparator();

                // 2. Add and demonstrate the static shipment counter & Static Constructor check
                Console.WriteLine($"[Initial Counter Check]");
                Console.WriteLine($"Total Shipments: {Shipment.GetTotalShipmentsCreated()}");
                DeliveryUtilities.PrintSeparator();

                DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "El-Galaa St.", 12);
                Shipment s1 = new Shipment("SH-101", "Electronics", 2.5m, 100m, originalAddress, "Pending");

                // 3. Demonstrate reference assignment between two shipment variables
                // 4. Demonstrate that reference assignment does not create a new object
                Console.WriteLine("[1. Reference Assignment Test]");
                Shipment s2 = s1; // Both s1 and s2 point to the exact same memory location

                Console.WriteLine($"s1 Tracking Code: {s1.TrackingCode}");
                Console.WriteLine($"s2 Tracking Code: {s2.TrackingCode}");
                Console.WriteLine($"Are s1 and s2 referencing the same instance? {object.ReferenceEquals(s1, s2)}");
                DeliveryUtilities.PrintSeparator();

                // 5. Create a Shallow Copy using MemberwiseClone()
                // 6. Demonstrate that the shallow copy shares the same DeliveryAddress
                Console.WriteLine("[2. Shallow Copy Test]");
                Shipment shallowCopy = s1.ShallowCopy();

                Console.WriteLine($"s1 Address City before change: {s1.Destination.City}");
                shallowCopy.Destination.City = "Alexandria"; 
                Console.WriteLine($"shallowCopy Address City: {shallowCopy.Destination.City}");
                Console.WriteLine($"s1 Address City after change (Shared reference!): {s1.Destination.City}");
                DeliveryUtilities.PrintSeparator();

                s1.Destination.City = "Cairo";

                // 7. Create a Deep Copy
                // 8. Demonstrate that the deep copy has an independent DeliveryAddress
                Console.WriteLine("[3. Deep Copy Test]");
                Shipment deepCopy = s1.DeepCopy();

                deepCopy.Destination.City = "Giza"; 
                Console.WriteLine($"s1 Address City: {s1.Destination.City}");
                Console.WriteLine($"deepCopy Address City (Independent): {deepCopy.Destination.City}");
                DeliveryUtilities.PrintSeparator();

                // 9. Demonstrate Extension Methods (ShipmentExtensions)
                Console.WriteLine("[4. Extension Methods Test]");
                Console.WriteLine($"Summary: {s1.GetSummary()}");
                Console.WriteLine($"Is Delivered? {s1.IsDelivered()}");

                s1.updateTrackingstatus("Delivered");
                Console.WriteLine($"Updated Summary: {s1.GetSummary()}");
                Console.WriteLine($"Is Delivered now? {s1.IsDelivered()}");
                DeliveryUtilities.PrintSeparator();

                // 10. Implement and demonstrate Partial Method
                Console.WriteLine("[5. Partial Method Test]");
                s1.updateTrackingstatus("In Transit"); 
                DeliveryUtilities.PrintSeparator();

                // 11. Final call to GetTotalShipmentsCreated()
                Console.WriteLine($"[Final Counter Check]");
                Console.WriteLine($"Total Shipments Created: {Shipment.GetTotalShipmentsCreated()}");
                DeliveryUtilities.PrintSeparator();
        }
            #endregion

    }
}
