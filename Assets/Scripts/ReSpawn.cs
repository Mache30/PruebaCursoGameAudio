using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    Vector3 spawnPosition = new Vector3 (15.41f , 6.86f,0);
    public AudioSource spawnSfx;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = spawnPosition;
            spawnSfx.Play();
        }
    }
   
}

