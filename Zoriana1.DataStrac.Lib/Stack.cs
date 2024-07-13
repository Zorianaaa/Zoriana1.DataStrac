namespace Zoriana1.DataStrac.Lib
{
    public class Stack
    {
        private object[] _items;
        private int _count;

        public Stack(int capacity = 4)
        {
            _items = new object[capacity];
            _count = 0;
        }

        public int Count => _count;

        public void Push(object item)
        {
            EnsureCapacity(_count + 1);
            _items[_count] = item;
            _count++;
        }

        public object Pop()
        {
            if (_count == 0)
            {
                Console.WriteLine("Стек порожній.");
                return null;
            }

            object item = _items[_count - 1];
            _items[_count - 1] = null;
            _count--;
            return item;
        }

        public object Peek()
        {
            if (_count == 0)
            {
                Console.WriteLine("Стек порожній.");
                return null;
            }
            return _items[_count - 1];
        }

        public void Clear()
        {
            Array.Clear(_items, 0, _count);
            _count = 0;
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public object[] ToArray()
        {
            object[] newArray = new object[_count];
            Array.Copy(_items, newArray, _count);
            return newArray;
        }

        private void EnsureCapacity(int capacity)
        {
            if (_items.Length < capacity)
            {
                int newCapacity = _items.Length == 0 ? 4 : _items.Length * 2;
                object[] newItems = new object[newCapacity];
                Array.Copy(_items, newItems, _count);
                _items = newItems;
            }
        }
    }
}
