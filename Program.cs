 int Max (int arg1,int arg2,int arg3);
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
 int max1 (int a1,int a2,int a3);
 int max2 (int b1,int b2,int b3);
 int max3 (int c1,int c2,int c3);
 int Max (int max1,int max2,int max3);
 Console.WriteLine (Max);
