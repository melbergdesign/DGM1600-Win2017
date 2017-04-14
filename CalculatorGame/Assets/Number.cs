using UnityEngine;
using System.Collections;

public class Number : MonoBehaviour {

	public string numButton;
	public TextEntry entry1 = new TextEntry();

	public void OnClick()
    {
        print(numButton);
		//assign entry to text box; need classes

    }
	/*public float upTownFunc(){
		numButton = entry1.TextConvert(numButton);
	}*/
}
