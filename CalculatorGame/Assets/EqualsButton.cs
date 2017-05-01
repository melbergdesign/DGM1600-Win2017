using UnityEngine;
using System.Collections;

public class EqualsButton : MonoBehaviour {
    public bool add;
    public bool subtract;
    public bool multiply;
    public bool divide;

	public void OnClick()
    {
        if (add)
        {
            print("Add");
            add = false;
        }
        if (subtract)
        {
            print("subtract");
            subtract = false;
        }
        if (multiply)
        {
            print("multiply");
            multiply = false;
        }
        if (divide)
        {
            print("divide");
            divide = false;
        }
    }
}
