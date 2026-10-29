using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //enteros ---> int
    // decimales --> float (f)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad = 0.09f;
    void Start()
    {
        ;
    }
    // AND ---> &&
    // OR --> ||
    //NOT --> !

    // Update is called once per frame
    void Update()
    {
        // = Asignar
        // == igual
        //GetKey, GetKeyUp y GetKeyDown
        if (Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * velocidad;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidad;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * velocidad;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * velocidad;
        }
    }
}