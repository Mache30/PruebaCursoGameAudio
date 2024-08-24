using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida = 100;
    GameObject canvaOver;
    public Reiniciar reiniciar;
    // Start is called before the first frame update
    void Start()
    {
        canvaOver = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 0)
        {
            reiniciar.gameOver = true;
        }
    }
}
