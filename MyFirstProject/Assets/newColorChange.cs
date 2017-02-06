using UnityEngine;
using System.Collections;

public class newColorChange : MonoBehaviour {
	//I prefer MonoDevelop

    // Update is called once per frame
    void Update() {
		//turns object red
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
            print("Changed color to Red");
        }
		//turns object green
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
            print("Changed color to Green");
        }
		//turns object blue
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            print("Changed color to blue");
        }
		//turns object white
		if (Input.GetKeyDown (KeyCode.Delete)) {
			GetComponent<Renderer> ().material.color = Color.white;
			print ("Changed color to white");
		}
		//Turns object black
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Renderer> ().material.color = Color.black;
			print ("Changed color to black");
		}
		//Turns object Yellow
		if (Input.GetKeyDown (KeyCode.Return)) {
			GetComponent<Renderer> ().material.color = Color.yellow;
			print ("Changed color to yellow");
		}

    }
}
