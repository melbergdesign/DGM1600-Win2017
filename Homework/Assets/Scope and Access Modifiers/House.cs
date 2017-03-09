using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class House : MonoBehaviour {
    public string owner = "Bob";//1-can be seen by unity IDE; Access modifier
    private string renter = "Sue";//2-NOT seen by unity IDE; Access modifier
    //3-Scope is how far something can be seen within the code.
    //4-both owner and renter can be seen by entire class, but renter cannot be accessed from outside the class
    private List<string> SuesPets;
    public List<string> BobsPets;

	// Use this for initialization
	void Start () {
        print(owner + " owns the house.");
        print(renter + " rents a room. You cannot interact with them.");
        print("Code does not work, but I understand the concepts of scope and access modifiers.");

        //SuesPets.Add("Cat");
        //SuesPets.Add("Bird");

        BobsPets.Add("Dog");

        //need a ForEach loop to print items in list
        if (owner == "Bob")
        {
            string child = "Sarah";//9-the Start() can see child, but child cannot access anything outside the if statement
            print(child);
        }

        //print(child); 10-will not work
	}
	
}
