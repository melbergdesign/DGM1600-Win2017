using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextEntry : MonoBehaviour {

    //receives and converts input into floats

    public InputField numberEntry;

    

    public void PrintEntry()
    {
        //print("This is a string " + numberEntry.text);

        float temp = float.Parse(numberEntry.text);

        print("This is a float " + temp);
    }

	
}
