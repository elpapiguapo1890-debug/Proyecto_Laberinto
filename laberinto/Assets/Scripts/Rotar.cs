using UnityEngine;

public class Rotar : MonoBehaviour
{
    float rotacionY = 100f;

    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);

    }
}
