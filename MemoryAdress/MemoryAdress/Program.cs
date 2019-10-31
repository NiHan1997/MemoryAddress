using System;
using System.Runtime.InteropServices;

namespace MemoryAdress
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = 10;
            int numB = numA;
            Console.WriteLine("numA 的地址: {0}", GetMemoryAddress(numA));
            Console.WriteLine("numB 的地址: {0}", GetMemoryAddress(numB));
            Console.WriteLine("------------------------------------------------------");

            string strA = "Light";
            string strB = strA;
            Console.WriteLine("strA 的地址: {0}", GetMemoryAddress(strA));
            Console.WriteLine("strB 的地址: {0}", GetMemoryAddress(strB));
            Console.WriteLine("------------------------------------------------------");

            int[] arrayA = new int[] { 1, 2, 3 };
            int[] arrayB = arrayA;
            Console.WriteLine("arrayA 的地址: {0}", GetMemoryAddress(arrayA));
            Console.WriteLine("arrayB 的地址: {0}", GetMemoryAddress(arrayA));

            Console.ReadKey();
        }

        /// <summary>
        /// 获取数据的地址.
        /// </summary>
        /// <param name="obj">表示任何类型的数据.</param>
        /// <returns>数据的内存地址.</returns>
        static string GetMemoryAddress(Object obj)
        {
            GCHandle handle = GCHandle.Alloc(obj, GCHandleType.Pinned);
            IntPtr address = handle.AddrOfPinnedObject();
            return "0x" + address.ToString();
        }
    }
}
