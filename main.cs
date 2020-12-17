using System;
using System.IO;
class MainClass {
	public static string RemoveHTML(string text) { text = text.Replace("echo ", ""); var oRegEx = new System.Text.RegularExpressions.Regex("<[^>]+>"); return oRegEx.Replace(text, string.Empty); }
	static void tre(){
		term();
	}
	static void term(){
		Console.Write("$ ");
		string cm = Console.ReadLine();
		if(cm.Contains("echo ") ){
			string ech = RemoveHTML(cm);
			Console.WriteLine(ech);
			tre();
		}
		if(cm == "exit"){
			Console.WriteLine("put \".exit\" to exit \n $ "); 
			string y = Console.ReadLine();
			if(y == ".exit"){
				 System.Environment.Exit(3);
			}
			else{
				tre();
			}
		}
		if(cm == "ls"){
			string[] files = Directory.GetFiles(@"./", "*", SearchOption.AllDirectories);
        Console.WriteLine(String.Join(Environment.NewLine, files));
			tre();
		}
		else{
			tre();
		}
	}
  public static void Main (string[] args) {
    term();
	}
}