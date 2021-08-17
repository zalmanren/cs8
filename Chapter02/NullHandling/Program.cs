using System;
using System.Collections.Generic;
using System.Linq;

namespace NullHandling // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var address  = new Address();
            address.Building = null;
            // address.Street = null; // 注意，这个神经病的现在又开始搞引用类型不能为空了
            address.City = "London";
            // address.Region = null;

            Console.WriteLine(address);
        }
    }
    class Address
    {
        public string? Building;
        public string Street = string.Empty; // 注意，这个神经病的现在又开始搞引用类型不能为空了
        public string City = string.Empty;
        public string Region = string.Empty;
    }
}