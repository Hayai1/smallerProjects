using System;
using System.Collections.Generic;
public class Node<T> where T : IComparable
{
    private T data;
    public T Data { get { return data; } }
    public Node<T> Left { get; private set; }
    public Node<T> Right { get; private set; }
    public Node(T data)
    {
        // TODO - add constructor code here
        this.data = data;
    }
    // TODO - implement the following properties (they should be readonly)
    private bool GreaterThan(T v1, T v2)
    {
        int comparison = v1.CompareTo(v2);
        return comparison == 1;
    }
    private void Traversal(List<T> IEnumerableOfT)
    {
        if (Left != null)
        {
            Left.Traversal(IEnumerableOfT);
        }
        IEnumerableOfT.Add(Data);

        if (Right != null)
        {
            Right.Traversal(IEnumerableOfT);
        }

    }
    public IEnumerable<T> GetTreeData()
    {
        // TODO - add code here to return an enumerable collection of tree
        // objects (of type 'T') in ascending order
        List<T> IEnumerableOfT = new List<T>();
        Traversal(IEnumerableOfT);
        return IEnumerableOfT;
    }
    private Node<T> Rec(Node<T> obj, T data)
    {
        if (GreaterThan(data, obj.Data))
        {
            if (obj.Right == null)
            {
                obj.Right = new Node<T>(data);
            }
            else
            {
                obj = Rec(obj.Right, data);
            }
        }
        else
        {
            if (obj.Left == null)
            {
                obj.Left = new Node<T>(data);
            }
            else
            {
                obj = Rec(obj.Left, data);
            }

        }
        return obj;
    }
    public void Insert(T data)
    {
        bool Flag = true;
        // TODO - add code here to implement inserting new data into tree
        while (Flag)
        {
            if (GreaterThan(data, Data))
            {
                if (Right == null)
                {
                    Right = new Node<T>(data);
                    Flag = false;
                }

                else
                {
                    Rec(Right, data);

                    Flag = false;
                }
            }
            else
            {
                //less
                if (Left == null)
                {
                    Left = new Node<T>(data);
                    Flag = false;
                }

                else
                {
                    Rec(Left, data);

                    Flag = false;
                }
            }
        }
    }

}
