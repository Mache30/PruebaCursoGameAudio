using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaJuego : MonoBehaviour
{
    public GameObject menuPausa;
    private bool juegoPausado = false;
    public GameObject filtroLow;
    public bool filtro = false;
    private bool mouse = false;

    public void Start()
    {
        // Asegúrate de que el menú de pausa esté desactivado al inicio.
        menuPausa.SetActive(false);
        
    }

    private void Update()
    {
        // Verifica si el jugador presiona la tecla "P" o "Escape".
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            // Invierte el estado del juego pausado.
            juegoPausado = !juegoPausado;

            if (!mouse)
            {
                Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
                mouse = true;
            }

            else
            {
                // Bloquear el cursor en el centro de la pantalla.
                Cursor.lockState = CursorLockMode.Locked;
                // Ocultar el puntero del mouse.
                Cursor.visible = false;
                mouse = false;
            }
            // Activa o desactiva el menú de pausa según el estado del juego.
            menuPausa.SetActive(juegoPausado);

            // Pausa o reanuda el tiempo en el juego según el estado del juego.
            Time.timeScale = (juegoPausado) ? 0f : 1f;
            if (filtro == false)
            {
                FiltroLow scriptA = filtroLow.GetComponent<FiltroLow>();
            scriptA.ActivarFiltro();
                filtro = true;
            }
            else
            {
                FiltroLow scriptA = filtroLow.GetComponent<FiltroLow>();
            scriptA.DesactivarFiltro();
                filtro = false;
            }


        }
    }

    // Agrega una función que se llame cuando el jugador presiona un botón para salir del juego.
    public void SalirDelJuego()
    {
        Time.timeScale = 1;
        Debug.Log("FUNKA");
        Application.Quit();
    }
}
