using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area_of_figure
{
    public class Area
    {
        public static double math_of_area(params double[] args)
        {
            int type = args.Length;
            if (type == 0)                  //функция возвращает отрицательные значения при ошибках. -1 - нет аргументов,
                 return -1;                 //или количество аргументов не верно и вычисление площади пока не реализовано.
            
            bool test = false;
            for (int i = 0; i < type; i++)
                if (args[i] < 0) 
                    test=true;
            if (test)
                return -2;                  //-2 - заданы отрицательные значения длинн

            double S = 0;            
            switch (type)
            {
                case 1:                     //фигура - круга
                {
                    S = Math.PI * args[0] * args[0];
                    return S;
                }
                case 3:                     //фигура - треугольник
                {
                    double a;
                    for (int i = 0; i < 2; i++)
                        for (int j = i + 1; j < 3; j++)
                            if (args[i] > args[j])
                            {
                                a = args[i];
                                args[i] = args[j];
                                args[j] = a;
                            }
                    a = args[0];
                    double b = args[1];
                    double c = args[2];
                    if ( c >= a + b)
                        if ( c == a + b)
                            return 0;       //данная фигура - прямая, а площадь прямой равна 0
                        else
                            return -3;      //треугольника с такими длинами не существует
                    if (c * c == a * a + b * b)
                    {
                        S=a*b*0.5;          //вычисляем прощадь прямоугольного треугольника
                        return S;
                    }
                    double p = (a + b + c) / 2;
                    S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return S;
                }
                default:
                    return -1; 
            }
        }
    }
}
