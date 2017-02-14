using UnityEngine;
using System.Collections;

public class ElseClause : MonoBehaviour {
	//the else clause cannot be used without an if statement. And If, else if, and else are all part of the same if statement
	//= assigns a value
	//== compares a value

	public bool iHaveMoney = true;

	public int cash = 7;

	// Use this for initialization
	void Start () {

		if (iHaveMoney) {
			print ("I'm rich!");
		} else {//this could also be written as if(!iHaveMoney), but it's a bit lengthy
			print ("I'm broke. :(");
		}

		//you can check for two conditions with &&
		if (iHaveMoney && cash >= 5) {
			print ("I can buy a cheeseburger.");
		} else {
			print ("But not enough for food.");
		}
		//you can check an OR condition with ||
		if (iHaveMoney || cash > 0) {
			print ("I only have " + cash + " dollars.");
		}

		//this situation is ridiculous:
		if (cash == 0) {
			print ("I am completely broke");
		} else if (cash == 1) {
			print ("I am not COMPLETELY broke");
		} else if (cash == 2) {
			print ("What can I buy for $2?");
		} else if (cash == 3) {
			print ("McDonald's Dollar Menu, here I come!");
		} else if (cash == 4) {
			print ("Enough for a gallon of milk");
		} else {
			print ("This is tedious enough.");
		}
	
	}
	
}
