using System.Runtime.CompilerServices;
using UnityEngine;

public class Pared : MonoBehaviour
{
    public Material materialEncendido;
    public Material materialApagado;
    bool encendido = false;
    float cronometro = 5f;
    private void Update()
    {
        if (encendido)
        {
            cronometro = cronometro - Time.deltaTime;
          print(cronometro);
            if (cronometro < 0f)
            {
                encendido = false;
                GetComponent<MeshRenderer>().material = materialApagado;
                cronometro = 2f;
            }

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent <MeshRenderer>().material = materialEncendido;
        encendido = true;
    }

}