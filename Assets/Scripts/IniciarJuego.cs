using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    public string nombreDeLaSiguienteEscena;

    // Este método se llama cuando se presiona el botón.
    public void CargarSiguienteEscena()
    {
        // Cargar la siguiente escena por nombre.
        SceneManager.LoadScene(nombreDeLaSiguienteEscena);
        AudioListener.pause = false;
    }
}

