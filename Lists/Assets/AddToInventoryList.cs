﻿using UnityEngine;
using System.Collections;

public class AddToInventoryList : MonoBehaviour {

	public Lists myInventory;
	public string myWeapon;

	public void AddToList(){
		myInventory.myWeaponList.Add (myWeapon);
	}

}
