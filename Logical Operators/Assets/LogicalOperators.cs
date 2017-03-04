using UnityEngine;
using System.Collections;

public class LogicalOperators : MonoBehaviour {

	//Dr. Suess is 113 yo this week

	public string string1;
	public string string2;
    //public string string3;

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
        /*if (string1 =="Thing 2" && string2 =="Thing 1"); This statement does not work b/c it conflict with the above OR statement
        {
            print("Switch your things.");
        }*/

        /*/if (string3) does not work b/c this is a boolean statement
        {
            print("That works");
        }*/
	
	}
	

}
