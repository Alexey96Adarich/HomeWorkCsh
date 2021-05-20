internal class MyDelegat
{

    public static int MyDelegat1(Student st1, Student st2) // Создаем метод для сравнения для экземпляров по возрасту
    {
        if (st1.age > st2.age)       // Сравниваем две строки
            return 1;
        else if (st1.age < st2.age)
            return -1;
        else
            return 0;
    }

    public static int MyDelegat2(Student st1, Student st2) // Создаем метод для сравнения для экземпляров по курсу и возрасту
    {
        if (st1.course > st2.course)
            return 1;
        else if (st1.course < st2.course)
            return -1;
        else
        {
            if (st1.age > st2.age)
                return 1;
            else if (st1.age < st2.age)
                return -1;
            else
                return 0;
        }
    }
}