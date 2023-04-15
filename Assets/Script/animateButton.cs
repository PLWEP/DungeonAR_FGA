using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class animateButton : MonoBehaviour
{
    public Animator anim;

    public void onTap()
    {
        anim.Play("open");
        anim.Play("close");
    }
}

