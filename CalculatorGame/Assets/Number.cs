using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class Number : MonoBehaviour {

    //number buttons

	public int numButton;
    public TextEntry numEntry;
    public TextEntry num2Entry;

    
	public void OnClick()
    {
        print(numButton);
        

        numEntry.charList.Add(numButton);

        StringBuilder builder = new StringBuilder();

        foreach(int i in numEntry.charList)
        {
            //print(i);
            builder.Append(i);
        }
        numEntry.numberEntry.text = builder.ToString();
    }
	
}
