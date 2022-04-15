 int Max (int arg1,int arg2,int arg3)
{
int result = arg1;
if (result < arg2) result = arg2;
if (result < arg3) result = arg3;
return result;
}

int a1 = 13;
int a2 = 14;
int a3 = 15;

int b1 = 21;
int b2 = 22;
int b3 = 23;

int c1 = 48;
int c2 = 49;
int c3 = 50;

 int max1 = Max (a1,a2,a3);
 int max2 = Max (b1,b2,b3);
 int max3 = Max  (c1,c2,c3);
 int  max = Max (max1,max2,max3);
 Console.WriteLine (max1);
 Console.WriteLine (max2);
 Console.WriteLine (max3);
 Console.WriteLine ($"Наибольшее число {max}");