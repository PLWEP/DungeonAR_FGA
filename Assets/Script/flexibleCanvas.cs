using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flexibleCanvas : MonoBehaviour
{
    public Canvas canvas;
    public GameObject target;

    void Start()
    {
        Resize();
    }

    void Resize()
    {
        RectTransform targetRect = target.GetComponent<RectTransform>();
        RectTransform canvasRect = canvas.GetComponent<RectTransform>();
        targetRect.sizeDelta = new Vector2(canvasRect.sizeDelta.x, canvasRect.sizeDelta.y);
    }
}
