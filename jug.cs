#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>


int main () {

float x,y,z,s,a,b,c,f;

printf("x");
scanf("%f",&x);
printf("y");
scanf("%f",&y);
printf("z");
scanf("%f",&z);

a=abs(x-y)*z+pow(x,2);
b=x+3*abs(x-y)+pow(x,2);
c=b/a;

f=0.25*acos(x)*c;
s=5*atan(x)-f;
printf("%f", s);
return 0;
}