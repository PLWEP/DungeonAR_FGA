using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour
{
    public VirtualButtonBehaviour vb;

    void Start()
    {
        vb.RegisterOnButtonPressed(onTap);
    }

    public void onTap(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button terklik");
        Application.OpenURL("https://hubs.mozilla.com/link/HavS8LG");
    }
}
