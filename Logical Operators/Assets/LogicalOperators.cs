using UnityEngine;
using System.Collections;

public class LogicalOperators : MonoBehaviour {

	//Dr. Suess is 113 yo this week

	public string string1;
	public string string2;

	// Use this for initialization
	public void OnButtonClick () {

		if (string1 == "Thing 1" && string2 == "Thing 2") {
			print ("These Things are quite tame.");
		}
		if (string1 == "Thing 1" || string2 == "Thing 2") {
			print ("It's fun to have fun if you know what to do.");
		}
		if (string1 != "Thing 1" && string2 != "Thing 2") {
			print ("Oh what a shame, what a shame, what a shame.");
		}
	
	}
	

}
