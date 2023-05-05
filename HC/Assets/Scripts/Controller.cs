using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D carRig; //corpo do veiculo
    public float speed;//variavel para a velocidade
    public Axle[] axles;//eixos do veiculo
    private float movement;//variavel para o calculo de movimento

    [System.Serializable]
    public class Axle
    {
        public Rigidbody2D wheel;
        public float torque;
    }

    // Atualizado a cada quadro redenrizado
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    //Executado de acordo com a fisica do jogo
    void FixedUpdate()
    {
        if (movement == -1)
            SetTorque(speed);
        else if (movement == 1)
            SetTorque(-speed);
        else
            SetTorque(0);
    }

    void SetTorque(float speed)
    {
        int nitro;
        nitro = 1;

        if (FuelDisplay.instance.GetFuel() > 0)
        {
            if (NitroDisplay.instance.GetNitro() > 0)
                nitro = 10;

            foreach (Axle axle in axles)
            {
                axle.wheel.AddTorque(
                    speed * (axle.torque * nitro) * Time.fixedDeltaTime );
                carRig.AddTorque(
                    -speed * (axle.torque * nitro) * Time.fixedDeltaTime);
            }
        }
    }
}
