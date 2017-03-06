using UnityEngine;
using System.Collections;

public class Access : MonoBehaviour {

    public Scope home;

	// Use this for initialization
	void Start () {
        print(home.owner);
        //print(home.renter);
        //print(home.Awakw());
        home.Awake();
	}
	
	
}
