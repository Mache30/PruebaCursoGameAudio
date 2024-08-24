using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    public string nombreDeLaSiguienteEscena;

    // Este m�todo se llama cuando se presiona el bot�n.
    public void CargarSiguienteEscena()
    {
        // Cargar la siguiente escena por nombre.
        SceneManager.LoadScene(nombreDeLaSiguienteEscena);
        AudioListener.pause = false;
    }
}

