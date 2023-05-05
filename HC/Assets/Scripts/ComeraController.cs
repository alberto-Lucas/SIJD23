using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ComeraController : MonoBehaviour
{
    public Transform car; //nosso objeto car 
    Vector3 offset; //movimentacao da camera

    // Start is called before the first frame update
    void Start()
    {
        //atualiza o offset com a posicao atual do veiculo
        offset = transform.position - car.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = 
            Vector3.Lerp(transform.position,
                         car.position + offset, 1);
                            
    }
}
