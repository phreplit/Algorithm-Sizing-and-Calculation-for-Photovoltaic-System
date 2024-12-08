
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Sizing and Calculation for Photovoltaic System in the area of ​​Photovoltaic Solar Energy, built for students and professionals in electrical engineering and related areas, such as renewable energies.

import java.io.IOException;
import java.util.Scanner; // import lib

public class Main {

public static void main(String[] args) throws IOException, InterruptedException {

loop: // choice Menu
while (true) {

  System.out.println("\n");
  System.out.println("\n");
  System.out.println(" Sizing and Calculation for Photovoltaic System ");
  System.out.println("");
  System.out.println("");
  System.out.println("1. Convert - volts [AC] to watts [DC]");
  System.out.println("2. Convert - watts [DC] to volts [AC]");
  System.out.println("3. Calculate the Power of the Modules");
  System.out.println("4. Calculate Weekly Solar Power Generation");
  System.out.println("5. Calculate Monthly Solar Power Generation");
  System.out.println("6. Calculate Annual Solar Power Generation");
  System.out.println("7. Calculate and Size the Number of Modules");
  System.out.println("[8] Info");
  System.out.println("[9] About");
  System.out.println("\n10. Exit");
  
  System.out.println("\nEnter your choice: ");

Scanner scanner = new Scanner(System.in);

int choice = scanner.nextInt();

try {
  
switch (choice) {
  case 1:
    double v2 = 10;
    System.out.println("\nEnter how many volts you want to convert to watts: "); 
    double v1 = scanner.nextInt();
    double result = (v1 * v2); 
    System.out.println("\n");
    System.out.println("\nThe " + v1 + " volts entered equals " + result + " watts."); 
    Scanner scanner1 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter = scanner1.nextLine();
    clear(); 
    break;
  case 2:
    double v4 = 10;
    System.out.println("\nEnter how many watts you want to convert to volts: ");  
    double v3 = scanner.nextInt();
    System.out.println("\n");
    double result1 = (v3 / v4);
    System.out.println("\nThe " + (v3) + " watts entered equals " + (result1) + " volts.");
    Scanner scanner2 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter2 = scanner2.nextLine();
    clear(); 
    break;
  case 3:  
    System.out.println("\nEnter the nominal power of the module in watts: ");  
    int v5 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the number of modules: ");  
    int v6 = scanner.nextInt();
    System.out.println("\n");
    int result2 = (v5 * v6);
    System.out.println("\nThe power of the modules will be " + (result2) + " watts.");
    Scanner scanner3 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter3 = scanner3.nextLine();
    clear();
  break;
  case 4:
    float v10 = 1000; // divide by 1000 to convert to kwh
    System.out.println("\nEnter the power of the modules in watts: ");   
    float v7 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the number of hours per day: ");   
    float v8 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nEnter the number of days per week: ");   
    float v9 = scanner.nextInt();
    System.out.println("\n");
    float v11 = (v7 * v8 * v9);
    float result3 = v11 / v10;
    System.out.println("\n the result will be " + (result3) + " kwh/week generation [east/west]");
    Scanner scanner4 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter4 = scanner4.nextLine();
    clear(); 
  break;
  case 5:
	float v15 = 1000; // divide by 1000 to convert to kwh
	System.out.println("\nEnter the power of the modules in watts: ");   
	float v12 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nEnter the number of hours per day: ");   
	float v13 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nEnter the number of days per month: ");   
	float v14 = scanner.nextInt();
	System.out.println("\n");
	float v16 = (v12 * v13 * v14);
	float result4 = v16 / v15;
	System.out.println("\n the result will be " + (result4) + " kwh/month generation [east/west]");
	Scanner scanner5 = new Scanner(System.in);
	System.out.println("\nPress enter to return to the menu...\n");
	String enter5 = scanner5.nextLine();
	clear();
  break;
  case 6:
        float v20 = 1000; // divide by 1000 to convert to kwh
	System.out.println("\nEnter the power of the modules in watts: ");   
	float v17 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nEnter the number of hours per day: ");   
	float v18 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nEnter the number of days per year: ");   
	float v19 = scanner.nextInt();
	System.out.println("\n");
	float v21 = (v17 * v18 * v19);
	float result5 = v21 / v20;
	System.out.println("\n the result will be " + (result5) + " kwh/year generation [east/west]");
	Scanner scanner6 = new Scanner(System.in);
	System.out.println("\nPress enter to return to the menu...\n");
	String enter6 = scanner6.nextLine();
	clear();	
  break;
  case 7:
	System.out.println("\nEnter the Calculated System Power (Pfv[BR]) in watts: ");   
	float v22 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nEnter the module's nominal power in watts: ");   
	float v23 = scanner.nextInt();
	System.out.println("\n");
	float result6 = (v22 / v23);
	System.out.println("\nThe maximum number of modules for this dimensioning is " + (result6) + " photovoltaic panels.");
	Scanner scanner7 = new Scanner(System.in);
	System.out.println("\nPress enter to return to the menu...\n");
	String enter7 = scanner7.nextLine();
	clear();
  break;
  case 8:
  clear();
  System.out.println("\n");
  System.out.println("Info");
  System.out.println("");
  System.out.println("To convert volts to watts, multiply the volts by 10.");
  System.out.println("To convert watts to volts, divide the watts by 10.");
  System.out.println("To calculate the power of the modules, multiply the nominal power of the module by the number of modules.");
  System.out.println("To calculate the weekly generation, use the calculation (power of the modules) x (hours per day) x (days per week) ");
  System.out.println("and the result will be in watts hour and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.");
  System.out.println("To calculate the monthly generation, use the calculation (power of the modules) x (hours per day) x (days per month) ");
  System.out.println("and the result will be in watts hour and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.");
  System.out.println("To calculate the annual generation, use the calculation (power of the modules) x (hours per day) x (days per year) ");
  System.out.println("and the result will be in watts hour and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.");
  System.out.println("To calculate and size the number of modules that composes a solar panel, we use the following calculation: ");
  System.out.println("Calculated system power (Pfv[BR]) in watts divided by the nominal power of the module in watts = the number of modules.");
  System.out.println("To convert 1kwh to 1wh, simply do the calculation, e.g.: 73kwh to wh will be 73000 wh.");
  System.out.println("");
  Scanner scanner8 = new Scanner(System.in);
  System.out.println("\nPress enter to return to the menu...\n");
  String enter8 = scanner8.nextLine();
  clear();
  break;
  case 9:
  clear();
  System.out.println("\n");
  System.out.println("Algorithm: Sizing and Calculation for Photovoltaic System");
  System.out.println("");
  System.out.println("Author: PHNO");
  System.out.println("Release Date: 29/11/2024");
  System.out.println("Version: 0.0.0.2v");
  System.out.println("Replit: @PHNO, @PHREPLIT");
  System.out.println("E-mail: phreplit@gmail.com");
  System.out.println("");
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nPress enter to return to the menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  break;
  case 10:
  System.out.println("\n Finished Algorithm! ");
  break loop;
  default:
    Scanner scanner01 = new Scanner(System.in);
    System.out.println("\n Error, choose again. ");
    System.out.println("\nPress enter to return to the menu...\n");
    String enter01 = scanner01.nextLine();
    clear();
    }
  } catch (Exception e) {
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nError, system failure!");
  System.out.println("\nPress enter to return to the menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  }            
}
}
public static void clear() {
     System.out.print("\033[H\033[2J"); // clear screen
     System.out.flush();
}
}
