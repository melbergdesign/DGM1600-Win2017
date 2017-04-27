using UnityEngine;
using System.Collections;

public class Number : MonoBehaviour {

    //number buttons

	public string numButton;
    public TextEntry numEntry;
	
	public void OnClick()
    {
        print(numButton);
        numEntry.numberEntry.text = numButton;		
    }
	
}
