import sys
try:
    a = int(input("Введите делимое: "))
    b = int(input("Введите делитель: "))
    s = a/b
    print (s)
except ZeroDivisionError:
    print ("Ошибка. На ноль делить нельзя!")
except ValueError:
    print ("Ошибка. Вы ввели не число!")
except Exception:
    print ("Глобальная ошибка.")
finally:    
    print("Размер типа данных int равен")
    print(sys.getsizeof(int))
    print("Размер типа данных float равен")
    print(sys.getsizeof(float))
    print("Конец программы")

