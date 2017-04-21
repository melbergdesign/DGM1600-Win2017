using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TextEntry : MonoBehaviour {

    //receives and converts input into floats
    //adds float to a list

    public InputField numberEntry;

    
    public void PrintEntry()
    {
        //print("This is a string " + numberEntry.text);

        float temp = float.Parse(numberEntry.text);

        print("This is a float " + temp);

        //mathOps.numberArray.Add
        
    }

}
