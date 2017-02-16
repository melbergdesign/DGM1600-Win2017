using UnityEngine;
using System.Collections;

public class WhileLoopHmwk : MonoBehaviour {

	//a while loop will continue to run as long as the conditional is true
	public bool powerDam = true;

	public string[] inventory;
	//cannot assign a variable to the array.Length

	//public int inventorySize;

	public int i;

	public int cookies = 6;

	public int sumInts = 3;

	public int n;

	// Use this for initialization
	void Start () {

		while (powerDam) {
			print ("The water flows!");

			powerDam = false;
			//you must make the conditional false to stop the loop or you will crash the computer
		}

		//inventory.Length = inventorySize

		print ("Your inventory contains:");
			
		while(i< inventory.Length){

			print (inventory[i]);

			i++;
		}
	

		while (cookies > 0) {
			print ("You ate the cookie.");

			cookies--;
		}

		print ("No more cookies");

		//the sum of n integers

		while (sumInts > 0) {//cannot increment and decrement a variable used in another loop
			//print (sumInts);

			n += sumInts;

			//print (n);

			sumInts--;
		}

		print ("Your total is " + n);

	}
		
		
}
