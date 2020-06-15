using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_실습_002___예외
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("예외 발생! : " + exception.Message);
                Console.WriteLine("분모의 값을 0 이외의 값으로 해주세요");
            }
            catch (Exception exception)
            {
                Console.WriteLine("예외 발생! : " + exception.Message);
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다");
            }


        }
    }
}
