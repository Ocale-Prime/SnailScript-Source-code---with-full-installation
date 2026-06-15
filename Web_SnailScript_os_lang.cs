using System;
using System.Formats.Asn1;

// WSS code system

namespace program_code_syntax
{
    class Local_syntax
    {
       public static void Syntax()
       {
          string[] Syntax_1 = 
          {
            "CREATE",
            "FUNCTION",
            "WHILE",
            "FOR",
            "IF",
            "HELP"
          }

          string[] keywords = 
          {
            "LOCAL",
            "GLOBAL",
            "LOCAB",
            "string",
            "Bool",
            "double"
          }

          var system = new system_function();

          string input = Console.ReadLine();
          Console.WriteLine("Welcome to the WSS Script + build in editor, if you are new, write [help] for the list of commands");

          if (input == "help")
          {
            system.load_function_n_32_localsystem();
            Console.WriteLine("Syntax 1: " +  Syntax_1[0] + " ," + Syntax_1[1] + " ," + Syntax_1[2] + " ," + Syntax_1[3] + " ," + Syntax_1[4] + " ," + Syntax_1[5] + " . Are All the Operators, the keywords will be listed below");
            system.init_psi();
            Console.WriteLine("Keywords: " + keywords[0] + " ," + keywords[1] + " ," + keywords[2] + " ," + keywords[3] + " ," + keywords[4] + " ," + keywords[5] + " . Are all the Keywords");
          }
          else if (input == Syntax[0])
          {
            Console.WriteLine("Please choose what you want to create: ");
            string input_2 = Console.ReadLine();

            system.load_init();
            system.load_psi_function()
            Console.WriteLine("Created! :" + input_2 + " , it is on the SnailScript memory, which you can accses with a specific command");
          }  
         else if (input == Syntax[1])
         {
           Console.WriteLine("The function is created, add the arguments: ");
           system.load_function();

           Console.WriteLine("Add for the best experience 3 arguments")

           void three_arguments()
           {
             var argument_dectector = new function_argument();
             if (argument_detector.maximum_dectetor < 3)
             {
               Console.WriteLine("Current Data system: Load functional data error: The system cannot start function");
               argument_detector.get_argumentData();
             }
           }
         }
       }
    }
}
