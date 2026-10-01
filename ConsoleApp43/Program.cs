Console.Write("İmtahanın tarixini daxil et (yyyy-MM-dd HH:mm): ");
string input = Console.ReadLine();

DateTime examDate = DateTime.Parse(input);
DateTime now = DateTime.Now;

if (examDate > now)
{
    TimeSpan remaining = examDate - now;

    Console.WriteLine($"İmtahana {remaining.Days} gün, {remaining.Hours} saat, {remaining.Minutes} dəqiqə qalıb.");
}
else
{
    Console.WriteLine("İmtahan artıq başlayıb və ya keçib.");
}