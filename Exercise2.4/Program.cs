using System;
Console.WriteLine();
for (int i = 0; i < 89; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine(
 format: "{0,-10} {1,1} {2,25} {3,35}",
  "Type", "Byt(s) of memory", "Min", "Max");

Console.WriteLine();
for (int i = 0; i < 89; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "sbyte", $"{sizeof(sbyte)}", $"{sbyte.MinValue}", $"{sbyte.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "byte", $"{sizeof(byte)}", $"{byte.MinValue}", $"{byte.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "short", $"{sizeof(short)}", $"{short.MinValue}", $"{short.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "ushort", $"{sizeof(ushort)}", $"{ushort.MinValue}", $"{ushort.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "int", $"{sizeof(int)}", $"{int.MinValue}", $"{int.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "uint", $"{sizeof(uint)}", $"{uint.MinValue}", $"{uint.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "long", $"{sizeof(long)}", $"{long.MinValue}", $"{long.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "ulong", $"{sizeof(ulong)}", $"{ulong.MinValue}", $"{ulong.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "float", $"{sizeof(float)}", $"{float.MinValue}", $"{float.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,40} {3,35}",
  "double", $"{sizeof(double)}", $"{double.MinValue}", $"{double.MaxValue}");
Console.WriteLine(
 format: "{0,-10} {1,1} {2,39} {3,35}",
  "decimal", $"{sizeof(decimal)}", $"{decimal.MinValue}", $"{decimal.MaxValue}");

Console.WriteLine();
for (int i = 0; i < 89; i++)
{
    Console.Write("-");
}
