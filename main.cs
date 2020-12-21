using System;
using System.IO;
class MainClass {
	public static string RemoveREAD(string text) { text = text.Replace("read ", ""); var oRegEx = new System.Text.RegularExpressions.Regex("<[^>]+>"); return oRegEx.Replace(text, string.Empty); }
	public static string RemoveECHO(string text) { text = text.Replace("echo ", "").Replace("##", ""); var oRegEx = new System.Text.RegularExpressions.Regex("<[^>]+>"); return oRegEx.Replace(text, string.Empty); }
	static void tre(){
		term();
	} 
	static void term(){
		Console.Write("$ ");
		string cm = Console.ReadLine();
		if(cm.Contains("echo ") ){
			string ech = RemoveECHO(cm);
			Console.WriteLine(ech);
			tre();
		}
		if(cm == "exit"){
			Console.WriteLine("put \".exit\" to exit \n"); 
			string y = Console.ReadLine();
			if(y == ".exit"){
				 System.Environment.Exit(0);
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
		if(cm.Contains("read ")){
			string fl = RemoveREAD(cm);
			string h = File.ReadAllText(@fl);
			Console.WriteLine(h);
			tre();
		}
		if(cm.Contains("##")){
			string d = RemoveECHO(cm);
			Console.WriteLine(d);
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