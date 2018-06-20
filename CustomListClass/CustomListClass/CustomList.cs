namespace CustomListClass
{

    public class CustomList<T>
    {
        int count = 0;
        int capacity = 0;        
        public T[] arr;                                       //constructor

        public T this[int i]                                 //Array List 
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public int Count
        {
            get
            {
             return count;
            }
        }

        public CustomList()
        {
            arr = new T[capacity + 1];
        } 
        
        public void Add(T items)                              //Add List 
        { 

            T[] temp = new T[capacity + 1];
            if (count >= capacity)
            {
                capacity = capacity * 2;
            }

            for (int i = 0; i < count; i++)
            {
                temp[i] = items;
            }
            temp[count] = items;
            arr[count] = items;
            items = items;
            count++;


        }









        //public void Remove(T item) 
        //{ 

        //} 
    }
} 
