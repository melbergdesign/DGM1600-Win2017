﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextEntry : MonoBehaviour {

    public InputField myInput;

    public float TextConvert(string textLine)
    {
        print(myInput.text);

        float temp = float.Parse(textLine);
        print (temp);
        return temp;

       
    }
}
