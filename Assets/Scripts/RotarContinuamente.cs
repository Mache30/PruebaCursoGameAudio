using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarContinuamente : MonoBehaviour

 {
    // Velocidad de rotación en grados por segundo
    public float velocidadRotacion = 30.0f;

    void Update()
    {
        // Rotar el objeto continuamente sobre su eje
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }
}
