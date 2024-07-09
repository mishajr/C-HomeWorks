using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Stack<T>
{

    private List<T> _elements = new List<T>();


    public void Push(T item)
    {

        _elements.Add(item);

    }

    public T Pop()
    {


        if (_elements.Count == 0)
        {

            throw new InvalidOperationException("Stack is empty.");

        }

        T item = _elements[_elements.Count - 1];

        _elements.RemoveAt(_elements.Count - 1);

        return item;
    }

    public T Peek()
    {

        if (_elements.Count == 0)
        {

            throw new InvalidOperationException("Stack is empty.");

        }

        return _elements[_elements.Count - 1];
    }

    public int Count
    {

        get { return _elements.Count; }

    }
}