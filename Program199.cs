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
    
    public void PerfectNum()
    {
        int iSum = 0;
        int i = 0;
        int iNum = 0;
        node temp = First;

        while(temp != null)
        {
            iNum = temp.data;
            iSum = 0;

            for(i = 1; i <= iNum / 2; i++)
            {
                if(iNum % i == 0)
                {
                    iSum = iSum + i;
                }
            }

            if((iSum == iNum)&&(iNum != 1))
            {
                Console.WriteLine(iNum+" is the pefect number");
            }   
            temp = temp.next;
        }
    }
}

class Program199
{
    static void Main(string[] Argv)
    {
        SinglyLL obj = new SinglyLL();

        obj.InsertFirst(89);
        obj.InsertFirst(6);
        obj.InsertFirst(41);
        obj.InsertFirst(17);
        obj.InsertFirst(28) ;
        obj.InsertFirst(11);

        obj.Display();

        obj.PerfectNum();
    }
}