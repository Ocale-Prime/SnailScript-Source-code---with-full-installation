using System;
using System.Formats.Asn1;

class Prgoram_input
{
    public static void Main(char[] args)
    {
        string[] keyword_commands =
        {
            "print",
            "reint_load<p::{}<load_krnl.exe>",
            "kernel<load{*}{}input::<>loader>",
            "kernel::Loader.exe{**}"
        };

        string input = Console.ReadLine();
        Console.WriteLine("Welcome to the SnailCommand(1), more types are coming");

        if (input == "help")
        {
            Console.WriteLine("Commands: " + keyword_commands[0]+ " " + keyword_commands[1] + " " + keyword_commands[2] + " " + keyword_commands[3]);
        }
        else if (input == keyword_commands[0])
        {
            Console.WriteLine("Enter the text to print");
            string txt_to_print = Console.ReadLine();
            Console.WriteLine(txt_to_print);
        }
        else if (input == keyword_commands[1])
        {
            Console.WriteLine("Loading kernel...");
            // Simulate loading kernel
            Console.WriteLine("Kernel loaded successfully.");
        }
        else if (input == keyword_commands[2])
        {
            Console.WriteLine("Loading kernel with input...");
            // Simulate loading kernel with input
            Console.WriteLine("Kernel loaded successfully with input.");
        }
        else if (input == keyword_commands[3])
        {
            Console.WriteLine("Loading kernel with loader...");
            // Simulate loading kernel with loader
            Console.WriteLine("Kernel loaded successfully with loader.");
        }
        else
        {
            Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
        }
    }
}

class Program_output : Prgoram_input
{
    private static void function32()
    {
        // Comming soon
        private void function_1(int time, char Letter_to_assign);
        var function_32 = new func32();
    }
}
