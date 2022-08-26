public class HelloWorld
{
public static void Main(string[] args)
{
int[] arr = new int[8];
Random rnd = new Random(999);
string otv = "";
int otvet = 0;

for(int i = 0; i < 8; i++){
arr[i] = rnd.Next(100, 999);
if (arr[i] % 2 == 0) {
otvet++;
}
otv += arr[i];
if (i<=6) {
otv += ",";
}
}
otv = "[" + otv + "] -> " + otvet;

Console.WriteLine (otv);
}
}
