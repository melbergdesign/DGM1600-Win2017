using UnityEngine;
using System.Collections;

public class KeyInput : MonoBehaviour {

	//2 kinds of inputs: Mouse and keyboard

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//inputs go here
		//listen for a keyboard input

		if(Input.GetKey(KeyCode.A)){//press the 'A' key
			print("I hit A");
		}
		//get axis = directional pad on a gamepad controller
		//location = Pokemon GO
		/*else{
		 * print ("No input");
		 * }
		 */
	
	}
}
