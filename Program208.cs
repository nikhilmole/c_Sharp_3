using System;

class node 
{
    public node next;
    public int data;

    public node(int iNo)
    {       
        next = null;
        data = iNo;
    }
}

class SinglyLL
{
    public node First;
    public int iCnt;
    public SinglyLL()
    {
        First = null;
        iCnt = 0;
    }
    public void Display()
    {
        node temp = First;

        if(temp == null)
        {
            Console.WriteLine("The LL is empty");
            return;
        }

        while(temp != null)
        {
            Console.Write("|"+temp.data+"|->");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
    public int Count()
    {
        return iCnt;
    }
    public void InsertFirst(int iNo)
    {
        node newn = new node(iNo);

        if(First == null)
        {
            First = newn;
        }
        else
        {
            newn.next = First;
            First = newn;
        }
        iCnt++;
    }
    public int Largest()
    {
        int iNo = 0;
        node temp = First;
        int Largest = temp.data;
        while(temp != null)
        {
            iNo = temp.data;
            if(Largest < iNo)
            {
                Largest = iNo;
            }
            temp = temp.next;
        }
        return Largest;
    }
}

class Program200
{
    static void Main(string[] Argv)
    {
        SinglyLL obj = new SinglyLL();
        obj.InsertFirst(9);
        obj.InsertFirst(32);
        obj.InsertFirst(20);
        obj.InsertFirst(11);

        obj.Display();

        int iRet = obj.Largest();
        Console.WriteLine(iRet); 
    }
}