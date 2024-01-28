using System;

class Program
{
    static void Main(string[] args)
    {
         // Create a scripture with a reference and text
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Create a UI to interact with the user
        ScriptureUI ui = new ScriptureUI(scripture);
        ui.Start();
    }
}