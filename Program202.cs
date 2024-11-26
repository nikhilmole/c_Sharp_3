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
    public int SecondMax()
    {
        int iNum = 0;
        node temp = First;
        int Max = temp.data;
        int SecondMax = 0;
        while(temp != null)
        {   
            iNum = temp.data;

            if(iNum > Max)
            {
                SecondMax = Max;
                Max = temp.data;
            }
            else
            {
                SecondMax = iNum;
            }
            temp = temp.next;
        }
        return SecondMax;
    }
}

class Program200
{
    static void Main(string[] Argv)
    {
        SinglyLL obj = new SinglyLL();
        int iRet = 0;

        obj.InsertFirst(41);
        obj.InsertFirst(32);
        obj.InsertFirst(20);
        obj.InsertFirst(11);

        obj.Display();

        iRet = obj.SecondMax(); 

        Console.WriteLine("SecondMax numbers is: "+iRet);
    }
}