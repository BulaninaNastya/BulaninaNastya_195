import java.util.Scanner;
public class Main
{
	public static void main(String[] args) {
		try 
	    { 
	    System.out.println("Тестировать функции деления двух чисел используя оператор исключения.");
	    System.out.println("Справка: при делении на ноль типов с плавающей точкой никогда не генерируется исключение,");
	    System.out.println("вместо этого всегда возращается значение, по умолчанию описанное в стандарте, то есть infinity.");
	    Scanner in1 = new Scanner(System.in);
        System.out.println("Введите делимое: ");
        double a = in1.nextDouble();
        Scanner in2 = new Scanner(System.in);
        System.out.println("Введите делитель: ");
        double b = in2.nextDouble();
        double s = a/b;
        System.out.println(s);
	    } 
	    catch(ArithmeticException e) 
	    {
	        System.out.print("Ошибка. На ноль делить нельзя!");
	    } 
	    catch(Exception e) 
	    {
	        System.out.print("Ошибка!");
	    } 
	    finally 
	    {
	        System.out.println("Конец программы");
	    }
	}
}