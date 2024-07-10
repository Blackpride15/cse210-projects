public class Entry
{
    public string Text { get; set; }
    public string Prompt { get; set; }
    public string Date { get; set; }

    public Entry(string text, string prompt, string date)
    {
        Text = text;
        Prompt = prompt;
        Date = date;
    }
}