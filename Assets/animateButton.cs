using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class animateButton : MonoBehaviour
{
    public VirtualButtonBehaviour vb;
    public Animator anim;

    void Start()
    {
        vb.RegisterOnButtonPressed(onTap);
    }

    public void onTap(VirtualButtonBehaviour vb)
    {
        Debug.Log("Animasi terklik");
        anim.Play("RotateAnimation");
        anim.Play("Idle");
    }
}

