using UnityEngine;
using System.Collections;

public class ScrollingMotion : MonoBehaviour {

    public GameObject thisObject;

    void Update()
    {
        thisObject.transform.Translate(0, -0.3f, 0);
    }
}
