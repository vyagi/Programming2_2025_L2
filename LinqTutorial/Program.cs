using LinqPractice;
using System.Linq;
using static System.Console;

var musicians = MusicData.Musicians;
var bands = MusicData.Bands;

var beforeLL = musicians.TakeWhile(x => !x.Name.Contains("ll"));

foreach (var item in beforeLL)
{
    Console.WriteLine(item.Name);
}

//var first = musicians.First();
//var firstTaller180 = musicians.First(x => x.Height > 180);
//var firstTaller200 = musicians.FirstOrDefault(x => x.Height > 200);


//var task28 = musicians
//    .Where(x => x.BirthDate.Year < 1960)
//    .OrderBy(x => x.Height)
//    .Select(x => string.Join("", x.Name.Split(" ").Select(x => x[0])));

//foreach (var item in task28)
//{
//    Console.WriteLine(item);
//}




//var task19 = musicians
//    .Where(x => x.BirthDate.Year < 1970)
//    .OrderBy(x => x.Height)
//    .Select(x => x.BirthDate);

//var byInstrumentsAndHeight =
//    musicians
//        .OrderByDescending(x => x.Instruments.Count())
//        .OrderBy(x => x.Height);

//foreach (var m in byInstrumentsAndHeight)
//    Console.WriteLine($"{m.Name} {m.Instruments.Count} {m.Height}");


//Task 9

//var musicianAges = musicians
//    .Select(x => x.DateOfDeath.HasValue
//                    ? x.DateOfDeath.Value.Year - x.BirthDate.Year
//                    : DateTime.Now.Year - x.BirthDate.Year);

//var musicianAgesOldSchool = musicians
//    .Select(x =>
//    {
//        if (x.DateOfDeath.HasValue)
//            return x.DateOfDeath.Value.Year - x.BirthDate.Year;
//        else
//            return DateTime.Now.Year - x.BirthDate.Year;
//    });

//foreach (var m in musicianAges)
//    Console.WriteLine(m);

//var guitarPlayers = musicians
//    .Where(x => x.Instruments.Any(y => y.Contains("Guitar")));

//var guitarPlayers1 = musicians
//    .Where(x => x.Instruments.Any(y => y.Split(' ').Contains("Guitar")));

//foreach (var m in guitarPlayers1)
//    Console.WriteLine(m.Name);

//Projection ordering filtration
//var alive = musicians.Where(x => !x.DateOfDeath.HasValue);
//foreach (var m in alive)
//    Console.WriteLine(m.Name);


////Basic Linq
////Task 10
//WriteLine(bands.Average(x => 2025 - x.FormationDate.Year));

////Task 6
//WriteLine(musicians.Max(x => x.BirthDate));

////Task 5
//WriteLine(musicians.Average(x => x.Hobbies.Count()));

////Task 2
//WriteLine(musicians.Min(x => x.Height));

////Task 1
//WriteLine(musicians.Count());
