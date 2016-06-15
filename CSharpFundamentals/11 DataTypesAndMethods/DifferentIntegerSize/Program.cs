using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            bool isSByte = false;
            bool isByte = false;
            bool isShort = false;
            bool isUShort = false;
            bool isInt = false;
            bool isUInt = false;
            bool isLong = false;
           
            try
            {
                sbyte a = Convert.ToSByte(num);
                isSByte = true;
            }
            catch (Exception){}
            try
            {
                byte a = Convert.ToByte(num);
                isByte = true;
            }
            catch (Exception){}
            try
            {
                short a = Convert.ToInt16(num);
                isShort = true;
            }
            catch (Exception) { }
            try
            {
                ushort a = Convert.ToUInt16(num);
                isUShort = true;
            }
            catch (Exception) { }
            try
            {
                int a = Convert.ToInt32(num);
                isInt = true;
            }
            catch (Exception) { }
            try
            {
                uint a = Convert.ToUInt32(num);
                isUInt = true;
            }
            catch (Exception) { }
            try
            {
                long a = Convert.ToInt64(num);
                isLong = true;
            }
            catch (Exception) { }

            if (!isByte && !isSByte && !isShort && !isUShort && !isInt && !isUInt && !isLong)
                Console.WriteLine($"{num} can't fit in any type");
            else
            {
                Console.WriteLine($"{num} can fit in:");
                if (isSByte) Console.WriteLine("* sbyte");
                if (isByte) Console.WriteLine("* byte");
                if (isShort) Console.WriteLine("* short");
                if (isUShort) Console.WriteLine("* ushort");
                if (isInt) Console.WriteLine("* int");
                if (isUInt) Console.WriteLine("* uint");
                if (isLong) Console.WriteLine("* long");
            }
           
        }
    }
}
