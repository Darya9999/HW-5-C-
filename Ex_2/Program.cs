public class HelloWorld
{
public static void Main(string[] args)
{
int[] arr = new int[6];
Random rnd = new Random(999);
string otv = "";
int otvet = 0;

for(int i = 0; i < 6; i++){
arr[i] = rnd.Next(-99, 99);
if (i % 2 == 1) {
otvet+=arr[i];
}
otv += arr[i];
if (i<=4) {
otv += ",";
}
}
otv = "[" + otv + "] -> " + otvet;

Console.WriteLine (otv);
}
}
