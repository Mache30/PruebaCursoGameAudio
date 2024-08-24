using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public bool victoriaActivada;
    public GameObject player;
    private SUPERCharacterAIO super;

    // Start is called before the first frame update
    void Start()
    {
        victoriaActivada = false;
        
        super = player.GetComponent<SUPERCharacterAIO>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si la colisión involucra al jugador
        if (victoriaActivada)
         {
            if (collision.gameObject.CompareTag("Player"))
        {

                // Cargar una escena de "Victoria" (reemplaza "NombreDeEscenaVictoria" con el nombre de tu escena de victoria)
                
                SceneManager.LoadScene("Victoria");
               
            
        }
        }
    }
    
}
