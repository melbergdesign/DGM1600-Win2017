using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TextEntry : MonoBehaviour {

    //receives and converts input into floats
    //adds float to a list

    public InputField numberEntry;
    public InputField numberEntry2;
    public float numEntered;
    public HoldList entryList;

    //each text entry should have it's own charList
    public List<int> charList = new List<int>();

    void Start()
    {
        numberEntry.interactable = true;
        numberEntry2.interactable = false;
    }

    /*public void PrintEntry()
    {
        numEntered = float.Parse(numberEntry.text);

        //print("This is a float " + numEntered);
        entryList.AddToList(numEntered);

        numEntered = float.Parse(numberEntry2.text);
        //entryList.AddToList(numEntered);
        
    }*/

}
