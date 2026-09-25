//MCCScript 1.0
MCC.LoadBot(new AutoBalanceScript());
//MCCScript Extensions

public class AutoBalanceScript : ChatBot
{
    public override void Initialize()
    {
        SendText("/bal");
    }

    public override void GetText(string text)
    {
        string cleanText = GetVerbatim(text);
        System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(cleanText, @"You have \$\s*([\d,]+)");

        if (match.Success)
        {
            string amount = match.Groups[1].Value;
            LogToConsole("Current money : " + amount + " $");
        }
    }
}
