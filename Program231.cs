using System;

class Program231
{
    static void MaxinDigo(int [][]Arr,int iRow, int iCol)
    {
        int i = 0;
        int j = 0;
        int Digo1 = Arr[0][0];
        int Digo2 = Arr[0][0];

        for(i = 0; i < iRow; i++)
        {
            for(j = 0; j< iCol; j++)
            {
                if(i == j)
                {
                    if(Digo1 < Arr[i][j])
                    {
                        Digo1 = Arr[i][j];
                    }
                }
                else if(i + j == iCol - 1)
                {
                    if(Digo2 < Arr[i][j])
                    {
                        Digo2 = Arr[i][j];
                    }
                }
            }
        }
        Console.WriteLine(Digo1);
        Console.WriteLine(Digo2);
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

        MaxinDigo(ptr,iNo1,iNo2);
    }
}