using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NitroDisplay : MonoBehaviour
{
    public Image nitro;
    public static NitroDisplay instance;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        nitro.fillAmount -= 
            Math.Abs(Input.GetAxis("Horizontal") / 1000f);
        //Math.Abs serve para retornar o valor absoluto
        //Ou seja remove o sinal de negativo
        //By Caio e Brunao
    }

    public void AddNitro()
    {
        nitro.fillAmount = 1;
    }

    public float GetNitro()
    { 
        return nitro.fillAmount;
    }

}
