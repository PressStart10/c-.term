using System;

class MainClass {
	public static string RemoveHTML(string text) { text = text.Replace("echo ", ""); var oRegEx = new System.Text.RegularExpressions.Regex("<[^>]+>"); return ""; }
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
		if(cm == ""){
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