using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CalculatorCondensed : MonoBehaviour {

	public InputField entry1;

	//public string x;
	//public string y;

	/*public void PrintEntry(){
		print (entry1.text);
	}*/

	public void EntryConvert(string textLine)
	{
		

		float temp = float.Parse(textLine);
		print (temp);
		return temp;


	}

	/*public void PrintEntry(string entryline){
		print(entry1.text);
		print (entry2.text);
	}*/
}
