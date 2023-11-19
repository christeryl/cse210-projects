public class Word
{
    public string Value { get; set; }
    public bool IsHidden { get; set; }

    public Word(string value)
    {
        Value = value;
        IsHidden = false;
    }
}
