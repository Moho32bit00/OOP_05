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
            #endregion
        }
    }
}
