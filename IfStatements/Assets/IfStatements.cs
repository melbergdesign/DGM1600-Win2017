using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	public bool myBool; //defaults to false
	public string myString = "dog";
	//unassigned ints default to 0
	public int num1;
	public int num2;

	public string animal = "Cat";

	// Use this for initialization
	void Start () {

		if (myBool) {//only runs if the statement is correct
			print ("true");
		}
		//check if something is true that is not a bool
		if (myString == "Cat") {
			print ("Cat");
		}
		if (!myBool) {//if mybool is false
			print(false);
		}
		if (myString != "Cat") { //!= is not
			print (myString);
		}
	
		//math equations
		if (num1 + num2 == 7) {
			print (7);
		}

		if (num1 + num2 != 7) {
			print (num1 + num2);		
		}
		//bad if statements; pirate code
		/*
		 * if (animal == "Cat"){
		 * 	print ("cat");
		 * }
		 * if (animal == "dog"){
		 * 	print ("dog");
		 * }
		 * if (animal == "Bird"){
		 * 	print ("bird");
		 * }
		 * 
		 * if (animal == "elephant"){
		 * 	print ("elephant");
		 * }
		 */
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//putting the script on an object twice creates two instances of the script on the object
	//refactoring = when your code is bad so you rewrite it (improvements)
	//make one change to the class and all the instances are changed
}
