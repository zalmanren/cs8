using static System.Console;
string variabletest = "abc";
for(int i = 1;i<=40;i++)
{
    WriteLine($"{CardinalToOrdianl(i)} "); // 不清楚为什么Write函数会显示不出
    formatstring();

}

/// <summary>
/// just for nothing
/// </summary>
/// <returns>test</returns>
static string formatstring()
{
    return "";
}
/// <summary>
/// pass a 32-bit integer and it will be converted into its ordinal equivalent
/// </summary>
/// <param name="number">Number is a cardinal value e.g. 1, 2, 3 and so on.</param>
/// <returns>Number as an ordianl value e.g. 1st, 2nd, 3rd, and so on.</returns>
static string CardinalToOrdianl(int number)
{
    switch(number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            string numberAsText=number.ToString();
            char lastDigit = numberAsText[numberAsText.Length - 1];
            string suffix = string.Empty;
            switch(lastDigit)
            {
                case '1':
                    suffix = "st";
                    break;
                case '2':
                    suffix = "nd";
                    break;
                case '3':
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }
            return $"{number}{suffix}";
    }
}