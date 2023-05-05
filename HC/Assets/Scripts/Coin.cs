using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.CompareTag("Player"))
        {
            CoinDisplay.instance.UpdateScore(coinValue);
            Destroy(gameObject);
        }
    }
}
