using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour
{
    public VirtualButtonBehaviour vb;
    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(onTap);
    }

    // Update is called once per frame
    public void onTap(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button terklik");
        Application.OpenURL("https://hubs.mozilla.com/link/HavS8LG");
    }
}
