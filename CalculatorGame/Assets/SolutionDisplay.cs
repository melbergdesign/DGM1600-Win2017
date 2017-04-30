using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SolutionDisplay : MonoBehaviour {

    //the solution must be parsed back into a string;

    public InputField Solution;
    //public MathOperations theOps;
    public float ans;
    public NewMathOperations NewOps;

    public void EqualsClick()
    {
        //Solution.text = theOps.answer.ToString();
        //Solution.text = theOps.solution;
        //Solution.text = ans.ToString();
    }
}
