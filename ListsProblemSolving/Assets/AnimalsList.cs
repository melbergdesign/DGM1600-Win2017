using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimalsList : MonoBehaviour {

	public List<string> Animals;

	void Start(){
		//item is identifier; cat is the value
		foreach (string item in Animals){
			if (item == "cat" || item == "Cat"){
				print (item);
			}
		}


	}

	

}
