using System;
namespace PracticaIntermedia1
{
    public class Excepcion : NullReferenceException
    {
        public Excepcion(string message):base(message)
        {
        }
    }
}
