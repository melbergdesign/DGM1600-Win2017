using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnCollision : MonoBehaviour {

    public Text gameOver;

    void Start()
    {
        gameOver.enabled = false;
    }

	void OnCollisionEnter (Collision bump)
    {
        gameOver.text = "GAME OVER";
        gameOver.enabled = true;
        
    }
}
