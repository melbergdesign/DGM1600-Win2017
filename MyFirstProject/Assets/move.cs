using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

		
	// Update is called once per frame
	void Update () {
		//hold the key
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			gameObject.transform.Translate (-.5f, 0, 0);
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			gameObject.transform.Translate (.5f, 0, 0);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			gameObject.transform.Translate (0, 0, .5f);
			print ("I am moving in z on purpose");
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			gameObject.transform.Translate (0, 0, -0.5f);
			print ("I am moving in z on purpose");
		}
	}

}