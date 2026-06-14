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
            "kernel::Loader.exe{**}",
            "load::operating_system<load_new::{}>function{*}{<void>?:load}",
            "Type<operating_system::load?>::function\\load[*]"
        };

        string input = Console.ReadLine();
        Console.WriteLine("Welcome to the SnailCommand(1), more types are coming");

        if (input == "help")
        {
            Console.WriteLine("Commands: " + keyword_commands[0]+ " " + keyword_commands[1] + " " + keyword_commands[2] + " " + keyword_commands[3] + " " + keyword_command[4] + " " + keyword_command[5]);
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
            Console.WriteLine("Kernel loaded successfully. Note: This is a simulation, accsesing the kernel is a big risk");
        }
        else if (input == keyword_commands[2])
        {
            Console.WriteLine("Loading kernel with input...  Please wite what you want to write to the kernel");
            string txt_to_krnl = Console.ReadLine();
            // Simulate loading kernel with input
            Console.WriteLine("Kernel loaded successfully with input: " + txt_to_krnl);
        }
        else if (input == keyword_commands[3])
        {
            Console.WriteLine("Loading kernel with loader...");
            Console.WriteLine("Loading the kernel is a big risk, we have simulated it in a sandboxed envoirment with its own Sandboxed kernel");
            // Simulate loading kernel with loader
            Console.WriteLine("Kernel loaded successfully with loader.");
        }
        else if (input == keyword_command[4])
        {
            Console.WriteLine("Sandboxed experience: Blocked, an error accures by loading a operating system, even when it is already loaded or not loaded");
            // Create local sandboxed for this particular command
            var local_sandbox_cmd = new sandbox32();
            local_sandbox_cmd.load_sandbox_operatingsys();
            Console.WriteLine("Background VM loaded");
            
        }
        else if (input == keyword_command[5])
        {
            Console.WriteLine("Availble software operating system: Windows x64 + Requirments: AMD ryzen 5000 series 7 + AMD Radeon graphics or higher. Intel CPU + Intel Graphics + Nividia Graphics or LumaOS G-Force Virtual graphics (depnding on the Operating system version of the Luma Installation process")
            var system_point = new function_additional_cpu_type();
            system_point.load_drivers_and_cpu();

            system_point.load_all_drivers();
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

    public static void Sandbox()
    {
        var function_new_sandbox = new Local_sand_box();
        function_new_sandbox.load_sandbox();

        string input_txt_main_command = Console.WriteLine();
        if (input_txt_main_command == "run<sandbox::envo>")
        {
            function_new_sandbox.initialize_sandbox();
            function_new_sandbox.initialize_functional_sandbox();
            function_new_sandbox.start();
        }
    }
}



class Program_sandbox_main : Program_output
{
    public static void function_main()
    {
        Console.WriteLine("Select CPU type for ")
        var function_32_init_sandbox_under_vm = new sandboxed_vm();
        function_32_init_sandbox_under_vm.load_vm();
        int[] cpu_datastructures = {32, 64, 86};

        string input_data_struct = Console.ReadLine();

        if (input_data_struct == "x32")
        {
            Console.WriteLine("You have written x" + cpu_datastructures[0] + " We will be loading the files for the System");
            function_32_init_sandbox_under_vm.load_cpu_x32_struct();
        }
        else if (input_data_struct == "x64")
        {
            Console.WriteLine("You have written x" + cpu_datastructures[1] + " We will be loading the files for the System");
            function_32_init_sandbox_under_vm.load_cpu_x64_struct();
        }
        else if (input_data_struct == "x86")
        {
             Console.WriteLine("You have written x" + cpu_datastructures[2] + " We will be loading the files for the System");
             function_32_init_sandbox_under_vm.load_cpu_x86_struct();
        }
        else
        {
            Console.WriteLine("please select a CPU type");
            Console.WriteLine("all bugs might be fixed");
        }
    }
}




class Loca_infract_docker1 : Program_sandbox_main
{
    private static readonly void Function_str()
    {
        var get_new_sandbox = new Docker_file();
        get_new_sandbox.load_sandbox_docker();

        get_new_sandbox.initialize_sandbox_system();
        get_new_sandbox.level_init_sec();
    }
}

class return_infract : loca_infract_docker1
{
    return 0;
}

// END
