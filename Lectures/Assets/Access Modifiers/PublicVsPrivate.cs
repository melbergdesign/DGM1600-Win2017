using UnityEngine;
using System.Collections;

public class PublicVsPrivate : MonoBehaviour {
    //implicit - it is implied
    //everything in C# is private by default

    int score = 100;//private
    private int health = 100;//private

    //sometimes you don't want the game designers to have access to things in the script

    // Use this for initialization

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /* Industry Jobs according to Anthony
     * 
     * Artists - only draw, paint textures; draws the Trex
     * Technical Artists - scripts (tools for artists to get the art in); builds a usable Trex; maya & unity
     * Game Designers - makes the game function
     * Scripters - Automate things for game designers
     * Programmers - works for unity and makes unity awesome (hardcore)
     * 
     * It's okay to just do what you know until you learn better
     * Make a mess! Just get it done!
     */
}
