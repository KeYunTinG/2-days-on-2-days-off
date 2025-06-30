// See https://aka.ms/new-console-template for more information
using System.Globalization;

var culture = new CultureInfo("zh-TW");
var today = DateTime.Today;

// 班表起算日
var startDate = new DateTime(2025, 6, 30); // 第一天為上班

Console.WriteLine("本週班表：");

// 從今天開始列出未來 7 天（或整週）
for (int i = 0; i < 7; i++)
{
    var date = today.AddDays(i);

    // 計算從起算日到當天的總天數
    int daysSinceStart = (int)(date - startDate).TotalDays;

    // 做二休二的 4 天循環
    int cycleDay = ((daysSinceStart % 4) + 4) % 4; // 確保為正值

    string status = (cycleDay == 0 || cycleDay == 1) ? "上班" : "休息";

    Console.WriteLine($"{date.ToString("dddd", culture)} {date:yyyy-MM-dd} - {status}");
}
