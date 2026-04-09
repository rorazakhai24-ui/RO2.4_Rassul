//Task1
int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;

foreach (int num in numbers)
{
    sum += num; 
}
Console.WriteLine("Sum = " + sum);

//Task 2
int[] temps = { 12, -3, 45, 0, 28, -10, 33 };


Array.Sort(temps);
Console.WriteLine("Min = " + temps[0]);
Console.WriteLine("Max = " + temps[temps.Length - 1]);


int min = temps[0];
int max = temps[0];
foreach (int t in temps)
{
    min = Math.Min(min, t); 
    max = Math.Max(max, t); 
}
Console.WriteLine("Min = " + min + ", Max = " + max);

//Task 3
string[] words = { "apple", "banana", "cherry", "date" };


Array.Reverse(words);
Console.WriteLine("Reverse 1: " + string.Join(" ", words));


Array.Reverse(words);


for (int i = 0; i < words.Length / 2; i++)
{
    string temp = words[i]; 
    words[i] = words[words.Length - 1 - i]; 
    words[words.Length - 1 - i] = temp; 
}
Console.WriteLine("Reverse 2: " + string.Join(" ", words));

//Task 4
int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
int even = 0;
int odd = 0;

foreach (int n in data)
{
    if (n % 2 == 0) even++; 
    else odd++;             
}
Console.WriteLine("Even = " + even + ", Odd = " + odd);

//Task 5
int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };


List<int> uniqueList = new List<int>();
foreach (int x in raw)
{
    if (!uniqueList.Contains(x)) uniqueList.Add(x);
}
Console.WriteLine("Unique 1: " + string.Join(" ", uniqueList));

int[] uniqueArr = raw.Distinct().ToArray();
Console.WriteLine("Unique 2: " + string.Join(" ", uniqueArr));

//Task 6
static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;
    int[] result = new int[n];
    k %= n; 

    for (int i = 0; i < n; i++)
    {
        
        result[i] = arr[(i + k) % n];
    }
    return result;
}

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int[] rotated = RotateLeft(arr, 3);
Console.WriteLine(string.Join(" ", rotated));

//Task 7

string s = "racecar"; 
bool isPalindrome = true;

for (int i = 0; i < s.Length / 2; i++)
{
    if (s[i] != s[s.Length - 1 - i])
    {
        isPalindrome = false; 
    }
}
Console.WriteLine(s + " это палиндром? " + isPalindrome);

//Task 8

static long Factorial(int n)
{
    long result = 1; 
    for (int i = 1; i <= n; i++)
    {
        result = result * i; 
    }
    return result;
}
//Task9 

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(FizzBuzz(i));
}

static string FizzBuzz(int n)
{
    if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz"; 
    if (n % 3 == 0) return "Fizz";                 
    if (n % 5 == 0) return "Buzz";                 
    return n.ToString();                          
}

//Task 10
double[] celsius = { 0, 20, 37, 100, -40 };


foreach (double c in celsius)
{
    double f = ToFahrenheit(c);
    Console.WriteLine(c + "°C = " + f + "°F");
}

static double ToFahrenheit(double c)
{
    return c * 9 / 5 + 32;
}

static double ToCelsius(double f)
{
    return (f - 32) * 5 / 9;
}