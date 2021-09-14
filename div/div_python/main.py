
import sys

num_1 = float(input("Введите первое число: "))
num_2 = float(input("Введите второе число: "))
myint = 13
myfloat = 2.80

def div(num_1, num_2):
    return num_1 / num_2
try:
    num_2 == 0
except ZeroDivisionError:
    print("Ошибка")
else:
    print("Ответ:",  div(num_1, num_2))




print("В переменной Int занимает: ", sys.getsizeof(myint), "Байт")
print("В переменной Float занимает: ", sys.getsizeof(myfloat), "Байт")
