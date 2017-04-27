using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TextEntry : MonoBehaviour {

    //receives and converts input into floats
    //adds float to a list

    public InputField numberEntry;
    public float numEntered;
    public HoldList entryList;

    
    public void PrintEntry()
    {
        numEntered = float.Parse(numberEntry.text);

        print("This is a float " + numEntered);

        entryList.AddToList(numEntered);
        
    }

}
