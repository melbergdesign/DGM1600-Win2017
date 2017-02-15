using UnityEngine;
using System.Collections;

public class WhileLoops : MonoBehaviour {
	//while loops will continue to run until the condition is false

	//iterator; commonly denoted as i
	//i will automatically == 0
	int i = 0;

	//iterate through an array
	//populate the array through the unity editor
	//set the size and then populate each element
	public string[] colors;

	// Use this for initialization
	void Start () {
		while (i< colors.Length) {//length is a parameter of an array
			print (colors[i]);
			//prints the element number i in each item in the array

			// i += 1; counts up
			i++;
		}

		print ("done");
	
	}
	
}
