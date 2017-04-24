using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TextEntry : MonoBehaviour {

    //receives and converts input into floats
    //adds float to a list

    public InputField numberEntry;
    //public string textEntered;
    public float numEntered;
    public HoldList entryList;

    
    public void PrintEntry()
    {
        //print("This is a string " + numberEntry.text);
        //textEntered = numberEntry.text;

        //print("This is the var " + textEntered);

        numEntered = float.Parse(numberEntry.text);

        print("This is a float " + numEntered);

        //mathOps.numberArray.Add
        entryList.AddToList;
        
    }

}
