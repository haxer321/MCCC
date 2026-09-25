//MCCScript 1.0
MCC.LoadBot(new AutoBalanceScript());
//MCCScript Extensions

using System.Text.RegularExpressions;

public class AutoBalanceScript : ChatBot
{
    public override void Initialize()
    {
        SendText("/bal");
    }

    public override void GetText(string text)
    {
        string cleanText = GetVerbatim(text);
        Match match = Regex.Match(cleanText, @"You have \$\s*([\d,]+)");

        if (match.Success)
        {
            string amount = match.Groups[1].Value;
            LogToConsole("Current money : " + amount + " $");
        }
    }
}
