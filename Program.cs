// зад 47 Устройство для заполнения массива вещественными числами
Console.Clear();
int m=new Random().Next(6,8);
int n=new Random().Next(6,8);
void PrintArray (double[,] array)
    {
        for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);j++)
                    Console.Write("{0,6:F2}", array[i,j]);
            Console.WriteLine();
            }
    }
double [,] FillArray(double[,] array1)
    {
        for (int i1=0;i1<array1.GetLength(0);i1++)
            for (int j1=0;j1<array1.GetLength(1);j1++)
                    array1[i1,j1]=new Random().Next(50)/10.0;
        return array1;
    }
double[,] array3=new double [m,n];
Console.WriteLine("Полученный массив");
PrintArray(FillArray(array3));