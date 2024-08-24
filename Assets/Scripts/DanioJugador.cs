using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanioJugador : MonoBehaviour

{
    public int danoPorSegundo = 1; // La cantidad de da�o que se inflige por segundo
    public float tiempoDeDanio = 1.0f; // La frecuencia de da�o en segundos
    private float tiempoUltimoDanio;
    Vida life;
    private bool jugadorEnPlataforma = false;
    SUPERCharacterAIO supercharacter;
    AudioSource daniovida;
    public GameObject sfxVida;
    private void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");
        life = playerObject.GetComponent<Vida>();
        supercharacter = playerObject.GetComponent<SUPERCharacterAIO>();
        
        daniovida =  sfxVida.GetComponent<AudioSource>();

    }
    private void OnCollisionEnter(Collision collision)
    {

        
            // Detecta la colisi�n con el jugador
            jugadorEnPlataforma = true;
        daniovida.Play();

        
    }
    private void OnCollisionExit(Collision collision)
    {
        
            // Detecta cuando el jugador sale de la colisi�n
            jugadorEnPlataforma = false;
        daniovida.Stop();

    }
    private void OnTriggerEnter(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void Update()
    {
        if (jugadorEnPlataforma)
        {
            if (Time.time - tiempoUltimoDanio > tiempoDeDanio)
            {
                // Aplica da�o si ha pasado el tiempo de danio
                AplicarDanio();
                Debug.Log("anda");
            }
        }


    }
   

    private void AplicarDanio()
    {
        // Reducir la vida del jugador
        // Por ejemplo, si el jugador tiene un script de vida, puedes usar algo como playerScript.ReducirVida(danoPorSegundo);
        life.vida = life.vida - danoPorSegundo;
        supercharacter.defaultSurvivalStats.Health = supercharacter.defaultSurvivalStats.Health - danoPorSegundo;
        // Actualizar el tiempo del �ltimo da�o
        tiempoUltimoDanio = Time.time;
    }
}