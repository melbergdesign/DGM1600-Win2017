using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Doorbell : MonoBehaviour {

    public string test = "Yes";
    public House myHouse;//5-creates an instance of the class, which allows you to access public parts of the parent class

	public void OnBobClick()//6-can be seen by unity IDE
    {
        print("Bob works.");
        foreach (string pet in myHouse.BobsPets)
        {
            print(myHouse.BobsPets.pet);
        }
        //7-pet is not accessible outside the foreach loop
    }

    public void onSueClick()//8-can be seen by unity IDE
    {
        print("Sue button works.");
    }
}
