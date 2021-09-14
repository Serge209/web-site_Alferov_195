package com.company;
import java.util.Scanner;
class Main {
    public static void main(String[] args) {

        Scanner num1 = new Scanner(System.in);
        System.out.print("Введите первое число!: ");
        double a = num1.nextDouble();
        Scanner num2 = new Scanner(System.in);
        System.out.print("Введите второе число!: ");
        double b = num2.nextDouble();
        double c;
        double result = 0;
        Scanner sc = new Scanner(System.in);
        try {
            c = a/b;
            System.out.print("Результат: " + c);
            if(a==0||b==0)
            {
                throw new Exception(" Ошибка!");
            }


        }
        catch (Exception err)
        {
            System.out.println(err.getMessage());
        }
        finally {

        }

    }


}
