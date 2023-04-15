using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour
{
    public void onTap()
    {
        Debug.Log("Button terklik");
        Application.OpenURL("https://hubs.mozilla.com/link/LQJxmRW");
    }
}
