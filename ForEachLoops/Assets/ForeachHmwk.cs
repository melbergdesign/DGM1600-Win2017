using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForeachHmwk : MonoBehaviour {
    //foreach loops are used to apply an action to each item in a collection
    public List<string> favoriteFoods;
    public GameObject thing;

    // Use this for initialization
    //trying to figure out how to search a scene for objects, then add them to a list
    //public static Object[] FindObjectsOfType<thing>();

    void Start () {
        foreach (string food in favoriteFoods)
        {
            print("I will eat the "+ food);
        }
}
	
}
