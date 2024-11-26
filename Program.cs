using Varosok_JobbagyMate;

List<VarosAdatok> varosAdatok = new List<VarosAdatok>();
StreamReader sr = new StreamReader(@"../../../src/varosok.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    varosAdatok.Add(new(sr.ReadLine()));
}

Console.WriteLine($"A kollekció hossza: {varosAdatok.Count}");

//1) hány millió fő él összesen kínai nagyvárosokban?
//2) mekkora az indiai nagyvárosok átlaglélekszáma?
//3) melyik nagyváros a legnépesebb?
//4) 20M lakos feletti nagyvárosok, népesség szerint csökkenő sorrendben.
//5) hány olyan ország van, ami több nagyávárossal is szerepel a listában?
//6) milyen betűvel kezdődik a legtöbb nagyváros neve?


// 1. feladat:
Console.WriteLine("1. feladat:");
float osszFo = varosAdatok.Sum(c => c.Nepesseg);
Console.WriteLine($"A kínai nagyvárosokban összesen {osszFo} millió fő él.");
Console.WriteLine("");

// 2. feladat:
Console.WriteLine("2. feladat:");
var india = varosAdatok.Where(c => c.OrszagNev == "India");
float indiaOssznep = india.Sum(c => c.Nepesseg);
float indiaiDb = india.Count();
Console.WriteLine($"Az indiai nagyvárosok átlaglélekszáma: {indiaOssznep / indiaiDb} millió fő");
Console.WriteLine("");

// 3. feladat:
Console.WriteLine("3. feladat:");
var legnepesebbSzam = varosAdatok.Max(c => c.Nepesseg);
var legnepesebb = varosAdatok.Select(c => c.Nepesseg == legnepesebbSzam);
Console.WriteLine($"{legnepesebb}");
Console.WriteLine("");

// 4. feladat:
Console.WriteLine("4. feladat:");
var nepessegCsokkeno = varosAdatok.OrderByDescending(c => c.Nepesseg);
foreach (var item in nepessegCsokkeno)
{
    Console.WriteLine($"\t- {item}");
}
Console.WriteLine("");

// 5. feladat:
