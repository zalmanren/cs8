// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "Type",
     "Byte(s) of memory",
     "Min",
     "Max"
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "sbyte",
     sizeof(sbyte),
     sbyte.MinValue,
     sbyte.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "byte",
     sizeof(byte),
     byte.MinValue,
     byte.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "short",
     sizeof(short),
     short.MinValue,
     short.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "ushort",
     sizeof(ushort),
     ushort.MinValue,
     ushort.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "int",
     sizeof(int),
     int.MinValue,
     int.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "uint",
     sizeof(uint),
     uint.MinValue,
     uint.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "long",
     sizeof(long),
     long.MinValue,
     long.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "ulong",
     sizeof(ulong),
     ulong.MinValue,
     ulong.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "float",
     sizeof(float),
     float.MinValue,
     float.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "double",
     sizeof(double),
     double.MinValue,
     double.MaxValue
);
Console.WriteLine(
     "{0,-8} {1, -26:N0} {2, -26:N0} {3, -26:N0}",
     "decimal",
     sizeof(decimal),
     decimal.MinValue,
     decimal.MaxValue
);
