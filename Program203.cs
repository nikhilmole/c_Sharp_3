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
    public void AddOfDigit()
    {
        int iDigit = 0;
        int iNo = 0;
        int iAdd = 0;
        node temp = First;

        while(temp != null)
        {   
            iNo = temp.data;
            iAdd = 0;

            while(iNo > 0)
            {
                iDigit = iNo % 10;
                iAdd = iAdd + iDigit;
                iNo = iNo / 10;
            }
            Console.WriteLine(iAdd);
            temp = temp.next;
        }
    }
}

class Program200
{
    static void Main(string[] Argv)
    {
        SinglyLL obj = new SinglyLL();
        obj.InsertFirst(41);
        obj.InsertFirst(32);
        obj.InsertFirst(20);
        obj.InsertFirst(11);

        obj.Display();

        obj.AddOfDigit(); 
    }
}