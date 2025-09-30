using System;
using System.IO;
using System.Text;

public static class ExcelEntry {
	static System.Text.StringBuilder SB = new System.Text.StringBuilder();
	
	static string Read(string Title) {
		Console.Write("{0}: ", Title);
		string InLine = Console.ReadLine().Trim();
		
		if (string.IsNullOrEmpty(InLine)) {
			return Read(Title);
		}
		
		return InLine;
	}
	
	static void Out(string Str) {
		SB.AppendLine(Str);
	}
	
	static void Out(string Fmt, params object[] Args) {
		Out(string.Format(Fmt, Args));
	}
	
	public static void Run()
	{
		DateTime CurDate = new DateTime(2025, 9, 1);
		DateTime EndDate = new DateTime(2025, 9, 30);
		
		Console.WriteLine("Generating from {0} to {1} ...", CurDate.ToString("dd.MM.yyyy."), EndDate.ToString("dd.MM.yyyy."));
		Console.WriteLine("Press [ENTER] to continue");
		Console.ReadLine();

		while (CurDate <= EndDate)
		{
			if (!(CurDate.DayOfWeek == DayOfWeek.Saturday || CurDate.DayOfWeek == DayOfWeek.Sunday))
			{
				string CurDateStr = CurDate.ToString("dd.MM.yyyy.");
				Out("SAŠA BARIŠIĆ\t{0}\t8\tREDOVNO\t08:00-16:00\tERSTE\tRedovan rad", CurDateStr);
			}
			CurDate = CurDate.AddDays(1);
		}

		if (File.Exists("out.txt"))
			File.Delete("out.txt");

		File.WriteAllText("out.txt", SB.ToString(), Encoding.UTF8);
	}
}