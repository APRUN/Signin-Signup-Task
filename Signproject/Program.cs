using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Signproject
{
    static class Program
    {
        static void Main()
        {
            int usercount = 0;
            string[] names = new string[5];
            string[] passwords = new string[5];
           header();

            int n_choice = menuview();
            /*clear();*/
            if(n_choice==1)
            {
                string name, password;
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                writetofile(name);
                Console.Write("Enter Password: ");
                password = Console.ReadLine();
               bool validity= Valid(name,names,usercount);
                if(validity==true)
                {
                    signupfunction(usercount,name,names,passwords,password);
                    Console.WriteLine("Signed In.");
                }
                Console.Read();
                
            }
        }
        static void header()
        {
            Console.WriteLine(" ## ##    ## ##   ### ###  #### ##  ##   ##    ##     ### ##   ### ###        ##   ##    ##     ###  ##    ##      ## ##   ### ###  ##   ##  ### ###  ###  ##  #### ##       ## ##   ##  ##    ## ##   #### ##  ### ###  ##   ##  ");
            Console.WriteLine("##   ##  ##   ##  ##  ##   # ## ##  ##   ##     ##     ##  ##   ##  ##         ## ##      ##      ## ##     ##    ##   ##   ##  ##   ## ##    ##  ##    ## ##  # ## ##       ##   ##  ##  ##   ##   ##  # ## ##   ##  ##   ## ##   ");
            Console.WriteLine("####     ##   ##  ##         ##     ##   ##   ## ##    ##  ##   ##            # ### #   ## ##    # ## #   ## ##   ##        ##      # ### #   ##       # ## #    ##          ####     ##  ##   ####       ##      ##      # ### # ");
            Console.WriteLine(" #####   ##   ##   ## ##     ##     ## # ##   ##  ##   ## ##    ## ##         ## # ##   ##  ##   ## ##    ##  ##  ##  ###   ## ##   ## # ##   ## ##    ## ##     ##           #####    ## ##    #####     ##      ## ##   ## # ##  ");
            Console.WriteLine("    ###  ##   ##   ##        ##     # ### #   ## ###   ## ##    ##            ##   ##   ## ###   ##  ##   ## ###  ##   ##   ##      ##   ##   ##       ##  ##    ##              ###    ##         ###    ##      ##      ##   ##  ");
            Console.WriteLine("##   ##  ##   ##   ##        ##      ## ##    ##  ##   ##  ##   ##  ##        ##   ##   ##  ##   ##  ##   ##  ##  ##   ##   ##  ##  ##   ##   ##  ##   ##  ##    ##          ##   ##    ##     ##   ##    ##      ##  ##  ##   ##  ");
            Console.WriteLine(" ## ##    ## ##   ####      ####    ##   ##  ###  ##  #### ##  ### ###        ##   ##  ###  ##  ###  ##  ###  ##   ## ##   ### ###  ##   ##  ### ###  ###  ##   ####          ## ##     ##      ## ##    ####    ### ###  ##   ##  ");
            Console.WriteLine();
        }
        static int menuview()
        {
            string inp="1";
            Console.Write("1. Sign Up.");
            Console.Write("2. Sign In.");
            Console.Write("3. Exit.");
            Console.ReadLine();
            int choice = 1;
            choice = int.Parse(inp);
            
            return choice;

        }
        static bool Valid(string name,string[] names,int usercount)
        {
            for(int m=0;m<=usercount;m++)
            {
                if(name==names[m])
                {
                    return false;
                }
                else
                {
                    usercount++;
                    return true;
                    
                }
            }
            return false;
        }
        static void signupfunction(int usercount,string name, string[] names,string[] passwords,string password)
        {
            names[usercount] = name;
            passwords[usercount] = password;
            usercount++;
            
        }
        static void clear()
        {
            Console.Clear();
            header();
        }
        static void writetofile(string var1)
        {
            string path = "C:\\2nd Semester\\Assignment\\OOP\\Week 1\\Signproject\\names.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine(var1);
            filevariable.Flush();
            filevariable.Close();
        }
    }
}
