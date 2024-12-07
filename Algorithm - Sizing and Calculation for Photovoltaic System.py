
'''  Author: PHNO - Technologist | Postgraduate
    Release Date: 29/11/2024
    Version: 0.0.0.2v
    Replit: @PHNO, @PHREPLIT
    E-mail: phreplit@gmail.com  '''

''' Algorithm: Sizing and Calculation for Photovoltaic System in the area of ​​Photovoltaic Solar Energy, built for students and professionals in electrical engineering and related areas, such as renewable energies. '''

import os # import lib - os clear
import sys
import json
import math

def reset_text():
    os.system('cls' if os.name=='nt' else 'clear')

op = 0 
while op != -1:
  print('')
  print('Sizing and Calculation for Photovoltaic System')
  print('')
  print('')
  print('1. Convert - volts [AC] to watts [DC]')
  print('2. Convert - watts [DC] to volts [AC]')
  print('3. Calculate the Power of the Modules')
  print('4. Calculate Weekly Solar Power Generation')
  print('5. Calculate Monthly Solar Power Generation')
  print('6. Calculate Annual Solar Power Generation')
  print('7. Calculate and Size the Number of Modules')
  print('[8] Info')
  print('[9] About')
  print('10. Exit')
  print('')
  op = int(input('Enter with your choice: '))
  if op == 1:
   v2 = float(10)
   print('')
   v1 = float(input('Enter how many volts you want to convert to watts: '))
   print('')
   result = float(v1 * v2)
   print('')
   print('The {} volts entered equals {} watts.'.format(v1,result))
   print('')
   print('Press enter to return to the menu...')
   a1 = str(input(''))
   reset_text()
  elif op == 2:
   v4 = float(10)
   print('')
   v3 = float(input('Enter how many watts you want to convert to volts: '))
   print('')
   result2 = float(v3 / v4)
   print('')
   print('The {} watts entered equals {} volts.'.format(v3,result2))
   print('')
   print('Press enter to return to the menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 3:
   print('')
   v5 = int(input('Enter the nominal power of the module in watts: '))
   print('')
   v6 = int(input('Enter the number of modules:  '))
   print('')
   result3 = v5 * v6
   print('')
   print('The power of the modules will be {} watts.'.format(result3))
   print('')
   print('Press enter to return to the menu...')
   a3 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 4:
   v11 = float(1000)
   print('')
   v7 = float(input('Enter the power of the modules in watts: '))
   print('')
   v8 = float(input('Enter the number of hours per day: '))
   print('')
   v9 = float(input('Enter the number of days per week: '))
   print('')
   v10 = float(v7 * v8 * v9)
   result4 = float(v10 / v11)
   print('')
   print('the result will be {} kwh/week generation [east/west].'.format(result4))
   print('')
   print('Press enter to return to the menu...')
   a4 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 5:
   v16 = float(1000)
   print('')
   v12 = float(input('Enter the power of the modules in watts: '))
   print('')
   v13 = float(input('Enter the number of hours per day: '))
   print('')
   v14 = float(input('Enter the number of days per month: '))
   print('')
   v15 = float(v12 * v13 * v14)
   result5 = float(v15 / v16)
   print('')
   print('the result will be {} kwh/month generation [east/west].'.format(result5))
   print('')
   print('Press enter to return to the menu...')
   a5 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 6:
   v21 = float(1000)
   print('')
   v17 = float(input('Enter the power of the modules in watts: '))
   print('')
   v18 = float(input('Enter the number of hours per day: '))
   print('')
   v19 = float(input('Enter the number of days per year: '))
   print('')
   v20 = float(v17 * v18 * v19)
   result6 = float(v20 / v21)
   print('')
   print('the result will be {} kwh/year generation [east/west].'.format(result6))
   print('')
   print('Press enter to return to the menu...')
   a6 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 7:   
   print('')
   v22 = float(input('Enter the Calculated System Power (Pfv[BR]) in watts: '))
   print('')
   v23 = float(input('Enter the module"s nominal power in watts:  '))
   print('')
   result7 = int(v22 / v23) # int and not float because the result will be print with more precision.
   print('')
   print('The maximum number of modules for this dimensioning is {} photovoltaic panels.'.format(result7)) # the result will be updated in the future. 
   print('')
   print('Press enter to return to the menu...')
   a7 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 8:
   reset_text()
   print('')
   print('Info')
   print('')
   print('To convert volts to watts, multiply the volts by 10.')
   print('To convert watts to volts, divide the watts by 10.')
   print('To calculate the power of the modules, multiply the nominal power of the module by the number of modules.')
   print('To calculate the weekly generation, use the calculation (power of the modules) x (hours per day) x (days per week) ')
   print('and the result will be in watt-hours and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.')
   print('To calculate the monthly generation, use the calculation (power of the modules) x (hours per day) x (days per month) ')
   print('and the result will be in watt-hours and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.')
   print('To calculate the annual generation, use the calculation (power of the modules) x (hours per day) x (days per year) ')
   print('and the result will be in watt-hours and then to get it in kwh we will divide by 1000 to convert to kwh, as calculated above.')
   print('To calculate and size the number of modules that composes a solar panel, we use the following calculation:')
   print('Calculated system power (Pfv[BR]) in watts divided by the nominal power of the module in watts = the number of modules.')
   print('To convert 1kwh to 1wh, simply do the calculation, e.g.: 73kwh to wh will be 73000 wh.')
   print('')
   print('Press enter to return to the menu...')
   a8 = str(input(''))
   reset_text()
  elif op == 9:
   reset_text()
   print('')
   print('Algorithm: Sizing and Calculation for Photovoltaic System')
   print('')
   print('Author: PHNO')
   print('Release Date: 29/11/2024')
   print('Version: 0.0.0.2v')
   print('Replit: @PHNO, @PHREPLIT')
   print('E-mail: phreplit@gmail.com')
   print('')
   print('Press enter to return to the menu...')
   a9 = str(input(''))
   reset_text()
  elif op == 10:
   print('')
   print('Finished Algorithm!')
   print('')
   break
  else: 
   print('')
   print('Error. Wrong Choice!')
   print('')
   print('Press enter to return to the menu...')
   a10 = str(input(''))
   reset_text()