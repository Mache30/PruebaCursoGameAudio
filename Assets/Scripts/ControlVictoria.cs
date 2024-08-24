using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVictoria : MonoBehaviour
{
    public int coleccionablesNecesarios = 3; // Número de coleccionables necesarios para la victoria.
    public Component componenteVictoria; // El componente de "victoria" que deseas desactivar.
    

    void Start()
    {
        ;
        // Encuentra el componente "victoria" en el GameObject actual.

        GetComponent<Victoria>().enabled = false;
        





    }

    private void Update()
    {
        if (coleccionablesNecesarios <= 0)
        {
            Victoria victoria = GetComponent<Victoria>();
            victoria.victoriaActivada = true;
        }
    }
    public void ControlRecogidos()
    {
        // Reduz la cantidad de coleccionables necesarios.
        coleccionablesNecesarios--;
        

        // Verifica si se han recolectado todos los coleccionables requeridos.
        if (coleccionablesNecesarios <= 0)
        {
            
            
            
            GetComponent<Victoria>().enabled = true;
            



        }
    }
}
