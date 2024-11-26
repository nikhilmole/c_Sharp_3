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
    public void PrimeNum()
    {
        int i = 0;
        int iNum = 0;
        node temp = First;

        while(temp != null)
        {
            iNum = temp.data;
            int isprime = 1;

            if(iNum <= 1)
            {
                isprime = 0;
            }

            for(i = 2; i <= iNum / 2; i++)
            {
                if(iNum % i == 0)
                {
                    isprime = 0;
                    break;
                }
            }

            if(isprime == 1)
            {
                Console.WriteLine(iNum+"is the prime number");
            }
            temp = temp.next;
        }
    }
}

class Program200
{
    static void Main(string[] Argv)
    {
        SinglyLL obj = new SinglyLL();
    
        obj.InsertFirst(89);
        obj.InsertFirst(6);
        obj.InsertFirst(41);
        obj.InsertFirst(17);
        obj.InsertFirst(28); 
        obj.InsertFirst(11);

        obj.Display();

        obj.PrimeNum();
    }
}