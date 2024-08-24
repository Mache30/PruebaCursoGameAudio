using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reiniciar : MonoBehaviour
{
    public bool gameOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            gameOver = false;
        }
        
    }
}
