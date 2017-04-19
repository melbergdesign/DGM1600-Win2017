using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextEntry : MonoBehaviour {

    public InputField numberEntry;

    public void PrintEntry()
    {
        print("This is a string " + numberEntry.text);
    }

	
}
