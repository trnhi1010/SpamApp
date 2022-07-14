using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        InvokeRepeating("RotateObj",0.2f,0.2f);
    }


    // Update is called once per frame
    void Update()
    {
    }

    void RotateObj()
    {
        rectTransform.Rotate(new Vector3(0,0,30));

    }
}
