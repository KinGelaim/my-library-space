namespace MyLibrarySpace.Extensions;

/// <summary>
/// Расширения для представления дат и времени
/// </summary>
public static class DateTimeExtensions
{
    /// <summary>
    /// Вывод даты-времени в формате 2023-01-01 13:23:10
    /// </summary>
    /// <param name="dateTime">Исходные дата-время</param>
    public static string ToDateAndTime(this DateTime dateTime) => dateTime.ToString("yyyy-MM-dd HH:mm:ss");
}