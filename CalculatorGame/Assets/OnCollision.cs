using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour {

	void OnCollisionEnter (Collision bump)
    {
        print("bump");
    }
}
