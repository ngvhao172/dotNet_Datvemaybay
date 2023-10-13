
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Http;
using System.Globalization;
namespace Csharp_DatVeMayBay.Util.CustomHelpers
{
    public class customHelper
    {
        public static string FormatCurrency(decimal amount)
        {
            return string.Format("{0:#,##0} đ", amount).Replace(",",".");
        }

        public static string FormatDateTime(DateOnly originalDate)
        {
            var tempDate = originalDate;
            return tempDate.ToString("yyyy-MM-dd");
        }
        public static string GetDuration(DateTime from, DateTime to)
        {
            var Duration = (to - from).ToString().TrimStart('0').TrimEnd('0').TrimEnd(':') + 'h';
            return Duration;
        }

        public static string[] splitDatetime(DateTime originalDate)
        {
            var tempDate = originalDate.ToString();
            Console.WriteLine(tempDate);
            var parts = tempDate.Split(" ");
            parts[1] = parts[1] + ' ' + parts[2];
            return parts;
        }
    }
}
