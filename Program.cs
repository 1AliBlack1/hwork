//Нахождение четного числа
Console.WriteLine("Input your number");
int userNum = Convert.ToInt32 (Console.ReadLine());
if (userNum % 2==1 )
{
    Console.WriteLine("odd");
}
else 
{
    Console.WriteLine("even");
}

//Нахождение большего из двух чисел
 Console.WriteLine ("Input first number");
  int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second number");
  int secNum = Convert.ToInt32(Console.ReadLine());
  if (secNum > firstNum)
  {

    Console.WriteLine ($"{firstNum} > {secNum}");

  }
else 
{

    Console.WriteLine ($"{firstNum} > {secNum}");
}

//Нахождение больлшего из трех чисел 
Console.WriteLine("Input First number");
int fsNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second number");
int scNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Third number");
int thrNum = Convert.ToInt32(Console.ReadLine());
int max = fsNum;
if (fsNum > scNum && fsNum >thrNum) max=fsNum;
else if (scNum > fsNum && scNum > thrNum) max=scNum;
else if (thrNum > fsNum && thrNum > scNum) max=thrNum;
else Console.WriteLine(+max + "is the BIGGEST number");
Console.WriteLine(+max + "is the BIGGEST number");

//Нахождение четных чисел от -N до N

Console.WriteLine("Enter your number");
int numberN = Convert.ToInt32(Console.ReadLine());

int numberNegative = numberN * (-1);

while (numberNegative <= numberN)
{

    Console.Write (numberNegative + ", ");
    numberNegative = numberNegative + 1;   // numberNegative +=1; numberNegative++
}
