using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

    public Homework animalInventory;
    public string newAnimal;

	public void OnMouseClick(){
        animalInventory.myAnimalsList.Add(newAnimal);
	}
}
