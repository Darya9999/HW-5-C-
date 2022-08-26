using System;

public class HelloWorld
{
public static void Main(string[] args)
{
double[] arr = new double[8];
Random rand = new Random(DateTime.Now.Millisecond);
string otv = "";
double otvet = 0;
double minimum = 0;
double maximum = 0;

for(int i = 0; i < 8; i++){
arr[i] = Math.Round(rand.NextDouble() * 20 , 2 );
};
minimum = arr[0];
maximum = arr[0];

for(int i = 0; i < 8; i++){
if (arr[i] < minimum) {
minimum = arr[i];
}
if (arr[i] > maximum) {
maximum = arr[i];
}
};
otvet = Math.Abs(maximum - minimum );

for(int i = 0; i < 8; i++){
otv += arr[i];
if (i<=6) {
otv += ",";
}
}
otv = "[" + otv + "] -> " + otvet;

Console.WriteLine (otv);
}
}
