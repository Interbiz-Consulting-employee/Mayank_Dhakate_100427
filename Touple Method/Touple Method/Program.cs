namespace Touple_Method
{
    using System;

    public class Program
    {
        static void Main()
        {
            // 1. Simple tuple
            var tuple = (1, "Hello", true);

            // Accessing items (properties)
            Console.WriteLine("Tuple Items:");
            Console.WriteLine(tuple.Item1); // 1
            Console.WriteLine(tuple.Item2); // Hello
            Console.WriteLine(tuple.Item3); // True

            // 2. Named tuple
            var namedTuple = (Id: 10, Name: "Mayank", IsActive: true);
            Console.WriteLine("\nNamed Tuple Items:");
            Console.WriteLine(namedTuple.Id);       // 10
            Console.WriteLine(namedTuple.Name);     // Mayank
            Console.WriteLine(namedTuple.IsActive); // True

            // 3. Nested tuple
            var nestedTuple = (1, "Mayank", Address: (City: "Delhi", Zip: 110001));
            Console.WriteLine("\nNested Tuple:");
            Console.WriteLine(nestedTuple.Item1);             // 1
            Console.WriteLine(nestedTuple.Item2);             // Mayank
            Console.WriteLine(nestedTuple.Address.City);     // Delhi
            Console.WriteLine(nestedTuple.Address.Zip);      // 110001

            // 4. ToString()
            Console.WriteLine("\nToString:");
            Console.WriteLine(tuple.ToString()); // (1, Hello, True)

            // 5. Equals()
            var t1 = (1, "Hello");
            var t2 = (1, "Hello");
            Console.WriteLine("\nEquals:");
            Console.WriteLine(t1.Equals(t2)); // True

            // 6. GetHashCode()
            Console.WriteLine("\nGetHashCode:");
            Console.WriteLine(tuple.GetHashCode());

            // 7. GetType() and Reflection to count elements
            Console.WriteLine("\nGetType and Reflection:");
            Type tupleType = tuple.GetType();
            Console.WriteLine(tupleType); // System.ValueTuple`3[System.Int32,System.String,System.Boolean]

            int elementCount = tuple.GetType().GetFields().Length;
            Console.WriteLine($"Number of elements in tuple: {elementCount}");

            // 8. Deconstruction
            Console.WriteLine("\nDeconstruction:");
            var (id, name, active) = tuple;
            Console.WriteLine(id);     // 1
            Console.WriteLine(name);   // Hello
            Console.WriteLine(active); // True

            // 9. Using tuple in a list
            var list = new List<(int Id, string Name)>();
            list.Add((1, "Mayank"));
            list.Add((2, "John"));

            Console.WriteLine("\nList of Tuples:");
            foreach (var item in list)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }
            Console.ReadLine();
        }
    }

}
