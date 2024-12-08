
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Sizing and Calculation for Photovoltaic System in the area of ​​Photovoltaic Solar Energy, built for students and professionals in electrical engineering and related areas, such as renewable energies.

#include <stdio.h> // import lib
#include <stdlib.h> 
#include <math.h> 

int menu(); 
void op1(); // header
void op2(); 
void op3();
void op4();
void op5();
void op6();
void op7();
void op8();
void reset_screen();
int menu_programmer();

int menu() { // Menu Function  
int op, c;

printf("\n  Sizing and Calculation for Photovoltaic System \n");
printf("\n");
printf("\n\t Menu \n");

printf("\n1. Convert - volts [AC] to watts [DC]");
printf("\n2. Convert - watts [DC] to volts [AC]");
printf("\n3. Calculate the Power of the Modules");
printf("\n4. Calculate Weekly Solar Power Generation");
printf("\n5. Calculate Monthly Solar Power Generation");
printf("\n6. Calculate Annual Solar Power Generation");
printf("\n7. Calculate and Size the Number of Modules");
printf("\n[8] Info\n");
printf("\n[9] About\n");
printf("\n10. Exit\n");

printf("\nEnter your choice: "); // option
scanf("%d", &op);

while ((c = getchar()) != '\n' && c != EOF) {
} // clear keyboard buffer.   
return op; 
}

int main() { // main function

int op = 0, c;

while (op != -1) { 
op = menu(); 
switch (op) { 
case 1: 
op1(); // function 1
break; 
case 2: 
op2(); // function 2
break; 
case 3: 
op3(); // function 3
break;
case 4:
op4(); // function 4
break;
case 5: 
op5(); // function 5
break; 
case 6: 
op6(); // function 6
break;
case 7:
op7(); // function 7
break;
case 8:
op8(); // function 8
break;
case 9:
menu_programmer(); // function 9
break;
case 10:
printf("\n");
printf("\n Finished Algorithm! \n"); // exit
printf("\n");
return 0;
break;
default: 
printf("\n");
printf("Wrong Option!\n"); 
printf("\n");
// printf("\n");
printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
} 
} 
return 0; 
} 

void op1() { 
double v1;
double v2 = 10;
double resultado;
printf("\n");
printf("\n Enter how many volts you want to convert to watts: ");
scanf("%lf", &v1, stdin);
resultado = (v1 * v2);
printf("\n");
printf("\n The %1.f volts entered equals %1.f watts. \n", v1, resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op2() { 
double v1;
double v2 = 10;
double resultado;
printf("\n");
printf("\n Enter how many watts you want to convert to volts: ");
scanf("%lf", &v1, stdin);
resultado = (v1 / v2);
printf("\n");
printf("\n The %1.f watts entered equals %1.f volts. \n", v1, resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op3() { 
int v1;
int v2;
int resultado;
printf("\n");
printf("\n Enter the nominal power of the module in watts: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\n Enter the number of modules: ");
scanf("%d", &v2, stdin);
resultado = (v1 * v2);
printf("\n The power of the modules will be %d watts.\n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op4() { 
float v1;
float v2;
float v3;
float v4;
float v5 = 1000;
float resultado;
printf("\n");
printf("\n Enter the power of the modules in watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Enter the number of hours per day: ");
scanf("%f", &v2, stdin);
printf("\n");
printf("\n Enter the number of days per week: ");
scanf("%f", &v3, stdin);
v4 = (v1 * v2 * v3);
resultado = v4 / v5;
printf("\n the result will be %.2f kwh/week generation [east/west]\n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op5() { 
float v1;
float v2;
float v3;
float v4;
float v5 = 1000;
float resultado;
printf("\n");
printf("\n Enter the power of the modules in watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Enter the number of hours per day: ");
scanf("%f", &v2, stdin);
printf("\n");
printf("\n Enter the number of days per month: ");
scanf("%f", &v3, stdin);
v4 = (v1 * v2 * v3);
resultado = v4 / v5;
printf("\n the result will be %.2f kwh/month generation [east/west]\n", resultado);

printf("\nPress enter to return menu...\n"); 
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op6() { 
float v1;
float v2;
float v3;
float v4;
float v5 = 1000;
float resultado;
printf("\n");
printf("\n Enter the power of the modules in watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Enter the number of hours per day: ");
scanf("%f", &v2, stdin);
printf("\n");
printf("\n Enter the number of days per year: ");
scanf("%f", &v3, stdin);
v4 = (v1 * v2 * v3);
resultado = v4 / v5;
printf("\n the result will be %.2f kwh/year generation [east/west]\n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op7() { 
float v1;
float v2;
float resultado;
printf("\n");
printf("\n Enter the Calculated System Power (Pfv[BR]) in watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Enter the module's nominal power in watts: ");
scanf("%f", &v2, stdin);
resultado = (v1 / v2);
printf("\n The maximum number of modules for this dimensioning is %.2f photovoltaic panels.\n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op8() { 
reset_screen();
printf("\n");
printf("\nInfo ");
printf("\n");
printf("\nTo convert volts to watts, multiply the volts by 10.\n");
printf("\nTo convert watts to volts, divide the watts by 10.\n");
printf("\nTo calculate the power of the modules, multiply the nominal power of the module by the number of modules.\n");
printf("\nTo calculate the weekly generation, use the calculation (power of the modules) x (hours per day) x (days per week) ");
printf("\nand the result will be in watt-hours and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.");
printf("\nTo calculate the monthly generation, use the calculation (power of the modules) x (hours per day) x (days per month) ");
printf("\nand the result will be in watt-hours and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.");
printf("\nTo calculate the annual generation, use the calculation (power of the modules) x (hours per day) x (days per year) ");
printf("\nand the result will be in watt-hours and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.");
printf("\nTo calculate and size the number of modules that composes a solar panel, we use the following calculation: \n");
printf("\nCalculated system power (Pfv[BR]) in watts divided by the nominal power of the module in watts = the number of modules.\n");
printf("\nTo convert 1kwh to 1wh, simply do the calculation, e.g.: 73kwh to wh will be 73000 wh.\n");
printf("\n");
printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void reset_screen(){
system("clear");      // linux
system("tput reset"); // linux
system("Cls"); // windows clear screen
return;
}

int menu_programmer(){
  reset_screen();
  printf("\n Algorithm: Sizing and Calculation for Photovoltaic System \n");
  printf("\n Author: PHNO ");
  printf("\n Release Date: 29/11/2024 ");
  printf("\n Version: 0.0.0.2v");
  printf("\n Replit: @PHNO, @PHREPLIT");
  printf("\n E-mail: phreplit@gmail.com \n");
  printf("\n Press enter to return menu...\n ");
  getchar();
  scanf("c\n");
  reset_screen();
  return 0;
}
