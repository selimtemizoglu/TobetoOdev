string sentence = "My name is Yavuz Selim Temizoğlu";

var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Derin Demiroğ";

bool result3 = sentence.EndsWith("ğ");
bool result4 = sentence.StartsWith("My Name");
var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf("");
var result7 = sentence.LastIndexOf("");
var result8 = sentence.Insert(0,"Hello,");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace("","-");
var result13 = sentence.Remove(2,4);
Console.WriteLine(result);


Console.ReadLine();