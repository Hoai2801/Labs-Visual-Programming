namespace Lab01;

public class People
{
    private string name;

    public People()
    {
    }

    public People(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
}