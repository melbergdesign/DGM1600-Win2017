using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SolutionDisplay : MonoBehaviour {

    //the solution must be parsed back into a string;

    public InputField Solution;
    public MathOperations theOps;
    public string test = "Hi";

    public void Start()
    {
        //Solution.text = theOps.answer.ToString();
        Solution.text = theOps.solution;
    }
}
