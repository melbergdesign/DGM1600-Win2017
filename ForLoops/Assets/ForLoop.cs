using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForLoop : MonoBehaviour {
	//tab tab will code complete
	//iterators count, they start at 0

	public List<string> cars;

	// Use this for initialization
	void Start () {

		//list.count
		//array.length; used for small things

		for (int i = 0; i < cars.Count; i++) {//i is the index of the current iteration
			print(cars[i]);			
		}
	
	}
	

}
