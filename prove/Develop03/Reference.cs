using System;

public class Reference
{
    public string References { get; private set; }

    public Reference(string reference)
    {
        References = reference;
    }

    public override string ToString()
    {
        return References;
    }
}