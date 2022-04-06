using System;

namespace PracticaIntermedia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.- Ternary Operator!--------------------------\n");
            Random r = new Random();
            int random = r.Next(0, 1000);
            string text;
            text = random >= 500 ? "Greather than 500" :"Less than 500";
            Console.WriteLine("The number: "+ random + " is: " + text) ;
            //Creations of exceptions-------------------
            Console.WriteLine("\n2.- Nullables and exceptions!--------------------------------\n");
            try
            {
                int? intNull = 3;
                string message= !intNull.HasValue ? throw new Excepcion("intNull doesn't have a value"):"the intNull has the value: "+intNull ;
                Console.WriteLine(message);
            }
            catch (Excepcion e)
            {
                Console.WriteLine(e.Message);
            }
            //Anonymous types--------------------------------
            Console.WriteLine("\n3.-Anonymous and dynamics!--------------------------------\n");
            var anonymousType = new {Name="Eduardo",Age=24 };
            Console.WriteLine("This is my anonymous type and it has the property name: "+ anonymousType.Name + " and the age: "+anonymousType.Age);


            //dynamic ----------------------
            dynamic dynamicValue = 30;
            Console.WriteLine("This is my dynamic value it has the int: " + dynamicValue);

            dynamicValue = "\"Look I'm a string now\"";
            Console.WriteLine("This is my dynamic value it has the string: " + dynamicValue);

            dynamicValue = new { Name = "John", LastName = "Wick", age = 57 };
            Console.WriteLine("This is my dynamic value it has the anonymous type with these properties: " + dynamicValue);

            Console.WriteLine("\n4.-Generics & Indexers!--------------------------------\n");

            //Generics & Indexers
            Map<DerivatedClassAbstract> GenericsExample = new Map<DerivatedClassAbstract>();
            //The indexer that receive a int as index
            GenericsExample[0] = new DerivatedClassAbstract("primer",12);
            GenericsExample[1] = new DerivatedClassAbstract("segundo", 15);
            GenericsExample[2] = new DerivatedClassAbstract("tercero", 120);

            DerivatedClassAbstract example = GenericsExample[0];
            Console.WriteLine("Using indexer with a int as a parameter: " + example.Value);
            //The indexer that use a string as indexer
            DerivatedClassAbstract stringExample = GenericsExample["primer"];

            Console.WriteLine("Using indexer as the stirng: \"primer\" as a parameter has the dynamic value:  "+stringExample.Value);

            Console.WriteLine("\n5.-Extension Methods!--------------------------------\n");

            Console.WriteLine("The value of the first position of a map with extension Methods is:  "+GenericsExample.FirstElement().Value);

            Console.WriteLine("\n6.- Regex!--------------------------------\n");
            String stringRegex = "Hola1234";
            Console.WriteLine("The string: " + stringRegex+" is valid: "+stringRegex.Validate()) ;
            stringRegex = "Pass4332";
            Console.WriteLine("The string: " + stringRegex + " is valid: " + stringRegex.Validate());
            stringRegex = "hola1234";
            Console.WriteLine("The string: " + stringRegex + " is valid: " + stringRegex.Validate());


        }


    }
}
