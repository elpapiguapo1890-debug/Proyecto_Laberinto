using TMPro;
using UnityEngine;

public class ganaste : MonoBehaviour
{

    [SerializeField]
    GameObject pantallaFinal;
    [SerializeField]
    TextMeshProUGUI textLabeltiempo;
    float tiempoDePartida = 0.0f;
    bool estajugando = true;
        private void Update()
        {
           if(estajugando == true)
           {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;

           }


        }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            
            pantallaFinal.SetActive(true);
            other.GetComponent<mover>().enabled = false;
            estajugando = false;
            textLabeltiempo.text = tiempoDePartida.ToString();
        }
    }
}