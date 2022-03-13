using VeeamLabs.Labs;

#region lab1
var rgbType = new ImmutableRgbType(1,2,3);

Console.WriteLine($"Red - {rgbType.Red}");
Console.WriteLine($"Green - {rgbType.Green}");
Console.WriteLine($"Blue - {rgbType.Blue}");

#endregion lab1

#region lab2
var baseValue = new BaseOverridden();
Console.WriteLine(baseValue.GetInfo());
var baseOverlap = new BaseOverlap();
Console.WriteLine(baseOverlap.GetInfo());
Console.WriteLine((baseOverlap as Base).GetInfo());

#endregion lab2