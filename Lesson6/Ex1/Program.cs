using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Lesson6;

/// <summary>
/// описание делегатов
/// </summary>
/// <param name="x"></param>
/// <returns></returns>
public delegate double Fun(double x);
public delegate double Fut(double a, double x);

class Program
{

    static void Main()
    {
        Menu.NewMethod();
    }
}