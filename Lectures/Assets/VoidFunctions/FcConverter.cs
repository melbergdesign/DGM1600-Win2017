using UnityEngine;
using System.Collections;

public class FcConverter : MonoBehaviour {
    //class that converts celsius to fahrenheit and back again
    //connect functions to a button
    //print converted value

    public float temperature;

	public void ConvertToCelsius()
    {
        float celsius;
        celsius = (temperature - 32f) / 1.8f;
        print(celsius);
    }
    public void ConvertToFahrenheit()
    {
        float fahrenheit;
        fahrenheit = temperature * 1.8f + 32f;
        print(fahrenheit);
    }
}
