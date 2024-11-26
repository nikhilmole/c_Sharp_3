using System;

class Program231
{
    static void Transpose(int [][]Arr,int iRow, int iCol)
    {
        int i = 0;
        int j = 0;
        int temp = 0;

        for(i = 0; i < iRow - 1; i++)
        {
            for(j = i + 1; j< iCol; j++)
            {
                temp = Arr[i][j];
                Arr[i][j] = Arr[j][i];
                Arr[j][i] = temp;
            }
           
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

        Transpose(ptr,iNo1,iNo2);
        Console.WriteLine("After swapping : ");
        for(i = 0; i < iNo1; i++)
        {
            for(j =0; j < iNo2;j++)
            {
                Console.Write(ptr[i][j]+"\t");
            }
            Console.WriteLine();
        }
    }
}