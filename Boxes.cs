namespace BoxesApp
{
    public class ReferenceBox<T> where T : class
    {
        // T ссылочный, поэтому null - обычное значение самого T
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
        // T никогда не бывает null, поэтому T? здесь - обёртка Nullable<T>
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
