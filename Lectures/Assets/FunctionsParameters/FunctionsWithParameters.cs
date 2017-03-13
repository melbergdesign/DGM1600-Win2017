using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FunctionsWithParameters : MonoBehaviour {

    //fields, variables, parameters
    public int health = 100;//scope is seen by other classes, local to this class
    public InputField myInputField;
    public string userName;

    public void UpdateUserName()
    {
        userName = myInputField.text;
        WelcomeUser(myInputField.text);
    }

    void WelcomeUser(string _name)
    {
        userName = _name;
        print("Welcome " + userName + "get ready to play!");
    }

    /*private void Start()
    {
        AddHealth(50);
        AddHealth(25);
        ReplaceHealth(25, 20);// this is the only thing that shows b/c it is the last instruction
    }

    public void AddHealth(int _h)//use first letter of word, parameter is local to function
    {
        health += _h;//adds _h to health; make like a health pick up in game
        print(health);
    }

    public void ReplaceHealth(int _a, int _b)
    {
        health = _a + _b;//reassigns health value
        print(health);
    }

    public void WelcomePlayer(string _name)
    {
        print("Welcome " + _name + ", it's good to have you.");
    }

    public string userName;

    public void UpdateStringValue(string _s)
    {
        userName += _s;
        print(userName);
    }*/
}
