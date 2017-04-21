using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HoldList : MonoBehaviour {

    public List<float> myHoldList = new List<float>();

	public void AddToList()
    {
        myHoldList.Add(3);
        print(myHoldList[0]);
    }
}
