using System;
namespace PracticaIntermedia1
{
    public class Map<T>
        where T : AbstractExample
    {
        private T[] arr = new T[100];
        public Map()
        {
        }


        //First indexer
        public T this[int i]
        {
            get => GetFieldByPosition(i);
            set => arr[i] = value;
        }
        //First indexer
        public dynamic this[string textValue] => GetIndexByString(textValue);




        private dynamic GetFieldByPosition(int position)
        {
            if (arr[position] == null)
            {
                Console.WriteLine("elemento inexistente");
            }



            return arr[position];
        }

        private dynamic GetIndexByString(string searchField)
        {

            try
            {
                foreach (var item in arr)
                {
                    if (item.Key.Equals(searchField))
                    {
                        return item;
                    }
                }
                throw new Excepcion("Element doesn't exist");
            }
            catch (Excepcion ex)
            {
                Console.WriteLine(ex);
            }
            return "Element doesn't exist";
        }

    }

   


}
