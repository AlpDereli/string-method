// See https://aka.ms/new-console-template for more informati
string degisken = "Dersimiz CSharp, Hosgeldiniz!";
string  degisken2 = "Dersimiz CSharp";
Console.WriteLine(degisken.Length);
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());
Console.WriteLine(string.Concat(degisken, " Merhaba!"));
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(string.Compare(degisken, degisken2, true));
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
Console.WriteLine(degisken.StartsWith("Merhaba!"));
Console.WriteLine(degisken.IndexOf("CS"));
Console.WriteLine(degisken.LastIndexOf("CS"));
Console.WriteLine(degisken.Insert(0, "Merhaba! "));
Console.WriteLine(degisken + degisken2.PadLeft(5, '*'));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Replace("CSharp", "C#"));
Console.WriteLine(degisken.Split(" ")[1]);
Console.WriteLine(degisken.Substring(3,6));


