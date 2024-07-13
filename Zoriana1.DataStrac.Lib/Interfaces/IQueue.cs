using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoriana1.DataStrac.Lib.Interfaces
{
    public interface ICollection
    {
        int Count { get; }
        void Clear();
        bool Contains(object item);
        object[] ToArray();
    }

    public interface IList : ICollection
    {
        object this[int index] { get; set; }
        void Add(object item);
        void Insert(int index, object item);
        void Remove(object item);
        void RemoveAt(int index);
        int IndexOf(object item);
        void Reverse();
    }

    public interface ISinglyLinkedList : ICollection
    {
        void Add(object data);
    }

    public interface IQueue : ICollection
    {
        void Enqueue(object item);
        object Dequeue();
        object Peek();
    }


}
