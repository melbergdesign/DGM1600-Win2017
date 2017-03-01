using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForeachLoops : MonoBehaviour {

	public List<GameObject> powerUpList;

	public List<GameObject> cubesList;
	public List<GameObject> sphereList;
	public List<GameObject> capsuleList;

	public void CheckData(){
		//check every item in the list
		//foreach (dataType identifier in collection)
		foreach (GameObject item in powerUpList) {
			switch (item.name) {
			case "Cube":
				cubesList.Add (item);
				break;

			case "Capsule":
				capsuleList.Add (item);
				break;

			case "Sphere":
				sphereList.Add (item);
				break;

			default:
				print ("Your shape sux.");
				break;
			}
		}
	}

}