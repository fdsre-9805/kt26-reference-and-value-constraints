namespace BoxesApp
{
    public class ReferenceBox<T> where T : class
    {

        private T? value;

        public bool IsEmpty => value is null;

        public void Set(T item)
        {
            value = item;
        }

        public T? Get()
        {
            return value;
        }
    }

    public class ValueBox<T> where T : struct
    {

        private T? value;

        public bool IsEmpty => !value.HasValue;

        public void Set(T item)
        {
            value = item;
        }

        public T? Get()
        {
            return value;
        }
    }
}
