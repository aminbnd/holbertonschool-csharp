using System;
/// <summary>
/// Customized Queue class
/// </summary>
/// <typeparam name="T">The elements type</typeparam>
public class Queue<T>
{
    /// <summary>
    /// head of the queue
    /// </summary>
    public Node head { get; set; }
    
    /// <summary>
    /// tail of the queue
    /// </summary>
    public Node tail { get; set; }
    
    /// <summary>
    /// integer
    /// </summary>
    public static int count { get; set; } = 0;
    

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if(count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count ++;
    }

    /// <summary>
    /// Method 
    /// </summary>
    /// <returns>Integer</returns>
    public int Count()
    {
        return count;
    }
    
    /// <summary>
    /// Method that returns the type of the Queue's elements
    /// </summary>
    /// <returns>The type of the Queue's elements</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }

    /// <summary>
    /// Node that encapsulates data
    /// </summary>
    public class Node
    {
        /// <summary>
        /// data
        /// </summary>
        public T value { get;set; } = default(T);


        /// <summary>
        /// next node
        /// </summary>
        public Node next { get; set; }
        
        /// <summary>
        /// Method
        /// </summary>
        /// <param name="value">any type</param>
        public Node(T value)
        {
            this.value = value;
        }

    }
}
