using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    internal class Messages
    {
        public static string TitleArt = @"
  ______  __  .__   __.  _______ .___  ___.      ___ 
 /      ||  | |  \ |  | |   ____||   \/   |     /   \     
|  ,----'|  | |   \|  | |  |__   |  \  /  |    /  ^  \    
|  |     |  | |  . `  | |   __|  |  |\/|  |   /  /_\  \   
|  `----.|  | |  |\   | |  |____ |  |  |  |  /  _____  \  
 \______||__| |__| \__| |_______||__|  |__| /__/     \__\ 
        ";
        public static string YouthPrice = "You get the youth price: ";
        public static string SeniorPrice = "You get the senior price: ";
        public static string OrdinaryPrice = "You get the ordinary price: ";

        public static void GreetVisitor() { WriteLine("Welcome to" + TitleArt); }
        public static string DisplayYouthPrice() { return YouthPrice; }
        public static string DisplaySeniorPrice() { return SeniorPrice; }
        public static string DisplayOrdinaryPrice() { return OrdinaryPrice; }
    }

}
