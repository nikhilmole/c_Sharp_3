using System;

class Program231
{
    static void AddCol(int [][]Arr,int iRow, int iCol)
    {
        int i = 0;
        int j = 0;

        for(i = 0; i < iRow; i++)
        {
            int iAdd = 0;
            for(j = 0; j< iCol; j++)
            {
                iAdd = iAdd + Arr[j][i];
            }
            Console.WriteLine(iAdd);   
        }
    }
    static void Main(String[] Argv)
    {   
        Console.WriteLine("Enter the number of rows : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of cols : ");
        int iNo2 = int.Parse(Console.ReadLine());

        int [][]ptr = new int[iNo1][];

        int i = 0;
        int j =0;

        for(i = 0; i < iNo1; i++)
        {
            ptr[i] = new int[iNo2];    
        }
        Console.WriteLine("Enter the elements : ");
        for(i = 0; i < iNo1; i++)
        {
            for(j =0; j < iNo2;j++)
            {
                ptr[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Entered elements are : ");
        for(i = 0; i < iNo1; i++)
        {
            for(j =0; j < iNo2;j++)
            {
                Console.Write(ptr[i][j]+"\t");
            }
            Console.WriteLine();
        }

        AddCol(ptr,iNo1,iNo2);
    }
}