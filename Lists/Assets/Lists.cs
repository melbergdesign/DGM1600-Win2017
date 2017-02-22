using UnityEngine;
using System.Collections;
//need this namespace to use lists
using System.Collections.Generic;

public class Lists : MonoBehaviour {
	//Lists are an object, not a function
	//<generic data type>
	//public List<string> myStringList;
	//array
	//public string[] myStringArray;

	//difference between array and list - able to use differently


	public List<string> myWeaponList;
	//public string[] myWeaponArray;

	// Use this for initialization



	void Start () {
		/*
		//array is unable to add new items to the array; Read only actions
		print (myStringArray.Length);

		//more dynamic capabilities - ex: add and remove items
		myStringList.Add ("Richard");
		myStringList.RemoveAt (0);*/


		/*myWeaponList.Remove ("Axe");
		myWeaponList.Add ("Bow");
		myWeaponList.Add ("scythe");

		myWeaponList.RemoveAt (1);*/

		//Create 3 buttons and each button adds a weapon to a list
	
	}

}
