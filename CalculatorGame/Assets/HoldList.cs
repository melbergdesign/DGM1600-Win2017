using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HoldList : MonoBehaviour {

    //holds the list of number entries

    public List<float> myHoldList = new List<float>();
    public TextEntry myEntry1;
    public TextEntry myEntry2;

      
	public void AddToList(float num)
    {
        //myHoldList.Insert(0, myEntry1.numEntered);
        //myHoldList.Insert(1, myEntry2.numEntered);
        myHoldList.Add(num);
    }

    public void PrintList()
    {
        print("This is in the list " + myHoldList[0]);
        print("This is in the list " + myHoldList[1]);
    }
}
