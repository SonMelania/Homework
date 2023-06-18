double nr1, nr2;
Console.WriteLine("introduceti nr1:");
 string tmp=Console.ReadLine();
nr1=double.Parse(tmp);
Console.WriteLine("introduceti n2:");
tmp = Console.ReadLine();
nr2 =int.Parse(tmp);

double sum=nr1+nr2;
Console.WriteLine("nr1+nr2=" + sum);
double dif=nr1-nr2;
Console.WriteLine("nr1-nr2=" + dif);
double div=nr1/nr2;
Console.WriteLine(" nr1/nr2=" + div);
double prod=nr1*nr2;
Console.WriteLine("nr1*nr2=" + prod);
double mod=nr1%nr2;
Console.WriteLine("nr1 modulo nr2=" + mod);

//write some exemple when you use the following operators:

int nr3 = 7;
nr3++;
Console.WriteLine(nr3);
nr3--;
Console.WriteLine(nr3);
nr3 += 2;
Console.WriteLine(nr3);
nr3 -= 4;
Console.WriteLine(nr3);

//write some exemple when you use the following operators:
bool rezultat = 7 == 8;
Console.WriteLine(rezultat);
rezultat = 7 != 8;
Console.WriteLine(rezultat);
rezultat = 7 != 8 && 7 == 7;
Console.WriteLine(rezultat);
rezultat = 7 != 8 || 7 ==7;
Console.WriteLine(rezultat);
Console.WriteLine(!rezultat);

