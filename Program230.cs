using System;

class PRogram230
{
    static int Freq(int [][]Arr, int iRow, int iCol, int iFind)
    {
        int i = 0; 
        int j = 0;
        int iCnt = 0;

        for(i = 0; i < iRow; i++)
        {
            for(j = 0; j < iCol; j++)
            {
                if(Arr[i][j] == iFind)
                {
                    iCnt++;
                }
            }
        }
        return iCnt;
    }
    static void Main(String[] Argv)
    {
        int i =  0;
        int j = 0;
        int iNo1 = 0;
        int iNo2 = 0;
        int iRet = 0;
        int iFind = 0;
        int [][]ptr;

        Console.WriteLine("Enter the number of rows : ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of cols : ");
        iNo2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number you want to find the freq");
        iFind = int.Parse(Console.ReadLine());

        ptr = new int[iNo1][];
        for(i = 0; i < iNo1; i++)
        {
            ptr[i] = new int[iNo2];
        }

        Console.WriteLine("Enter the elements");
        for(i = 0; i < iNo1; i++)
        {
            for(j = 0; j < iNo2; j++)
            {
                ptr[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Entered elements are");
        for(i = 0; i < iNo1; i++)
        {
            for(j = 0; j < iNo2; j++)
            {
                Console.WriteLine(ptr[i][j]+"\t");
            }
        }

        iRet = Freq(ptr,iNo1, iNo2, iFind);
        Console.WriteLine("The frequency is : "+iRet);
    }
}