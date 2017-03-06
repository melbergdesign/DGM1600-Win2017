using UnityEngine;
using System.Collections;

public class Scope : MonoBehaviour {

	public string owner = "Bob";//accessible in entire class
    //variables can go in, they cannot come out{}
    private string renter = "Kate";//unity can't see this, can be seen inside Awake

	public void Awake(){
		string cat = "Joe";//local variable, only available within the Awake function
        if (cat == "Joe")
        {
            string mouse = "Helen";//Awake cannot see this variable, but the if statement can see cat variable
            print(cat + " ate " + mouse);
            print(renter);
        }
        //print(mouse); unable to print; does not exist outside if statement
		print(cat);
		print (owner);
        print(renter);
	}
	//OOP = Awake is an object, anything inside is local only to awake.
	void Start () {
        string cat = "Frank";
        print (cat);
		print (owner);
	}
	

}
