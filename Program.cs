/*int [] CreateNewArray (int m)
{
    int [] arrayM = new int [m];
    Console.WriteLine("Create array here:");
    for (int i = 0; i< m; i++)
    {
        Console.WriteLine ( $"Input {i + 1} elements:");
        arrayM [i] = Convert.ToInt32 (Console.ReadLine());
    }
Console.WriteLine();
return arrayM;
}
void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array [i] + " ");
}
int NumberBiggerThanZero (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
      {
        if (array[i] > 0) count = count +1;
      }
    return count;
}
Console.WriteLine ("Input size of array:");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = CreateNewArray (m);
ShowArray (array);
Console.WriteLine("The number bigger than zero :" + NumberBiggerThanZero(array));
*/

/*void FindPointCoordinats ( double k1,  double  b1,  double k2,  double b2)
{
  double x;
  double y;
  x = (b2 - b1) / (k1 - k2);
  y = k2 * x + b2;
  Console.WriteLine ("Point coordinate x is : " + x + ", point coordinate y is : " + y);
  
}   
Console.WriteLine ("Input k1 : ");
double k1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine ("Input b1 : ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input k2 : ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input b2 : ");
double b2 = Convert.ToDouble(Console.ReadLine());
FindPointCoordinats ( k1,b1,k2,b2);
*/

