using System;

class Program229
{
    static int DigoAdd(int [][]Arr, int iRow, int iCol)
    {
        int iSum = 0;
        int i = 0; 
        int j = 0;

        for(i = 0; i < iRow; i++)
        {
            for(j = 0; j < iCol; j++)
            {
                if(i == j)
                {
                    iSum = iSum + Arr[i][j];
                }
            }
        }
        return iSum;
    }
    static void Main(string[] argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;
        int iRet = 0;
        int i = 0;
        int j = 0;
        int [][]Arr;

        Console.WriteLine("Enter the number of rows : ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of cols : ");
        iNo2 = int.Parse(Console.ReadLine());

        Arr = new int[iNo1][];

        for(i = 0; i < iNo1; i++)
        {
            Arr[i] = new int[iNo2];
        }

        Console.WriteLine("Enter the element : ");
        for(i = 0; i < iNo1; i++)
        {
            for(j = 0; j < iNo2; j++)
            {
                Arr[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The Entered data is : ");
        for(i = 0; i < iNo1; i++)
        {
            for(j = 0; j < iNo2; j++)
            {
                Console.Write(Arr[i][j]+"\t");
            }
            Console.WriteLine();
        }

        iRet = DigoAdd(Arr,iNo1,iNo2);
        Console.WriteLine("The Addition is : "+iRet);
    }
}