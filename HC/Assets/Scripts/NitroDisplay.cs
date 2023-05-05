using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NitroDisplay : MonoBehaviour
{
    public Image nitro;
    public static NitroDisplay instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        nitro.fillAmount -=
            Math.Abs(Input.GetAxis("Horizontal") / 100f);
    }

    public void AddNitro()
    {
        nitro.fillAmount = 1;
        //fuel.fillAmount += 0.1f; 10%
    }

    public float GetNitro()
    {
        return nitro.fillAmount;
    }
}
