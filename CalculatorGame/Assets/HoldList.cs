using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HoldList : MonoBehaviour {

    public List<float> myHoldList = new List<float>();
    public TextEntry myEntry1;
    public TextEntry myEntry2;

      
	public void AddToList()
    {
        myHoldList.Add(myEntry1.numEntered);
        myHoldList.Add(myEntry2.numEntered);
    }

    public void PrintList()
    {
        print("This is in the list " + myHoldList[0]);
        print("This is in the list " + myHoldList[1]);
    }

    /*public void Update()
    {
        
    }*/
    //myHoldList.Add("yes");
}
