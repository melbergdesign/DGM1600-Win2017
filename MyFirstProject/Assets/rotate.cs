using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//every frame, rotate a certain amount
		transform.Rotate(new Vector3(15,30,45)*Time.deltaTime*speed);
		//time.deltatime calculates the time of the frames
	}
}
