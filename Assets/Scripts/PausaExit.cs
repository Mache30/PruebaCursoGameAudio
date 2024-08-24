using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaExit : MonoBehaviour
{
    // Start is called before the first frame update
    public void SalirDelJuego()
    {

        // Comprueba si la aplicaci�n se est� ejecutando en el editor de Unity.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Si no estamos en el editor, cierra la aplicaci�n.
        Application.Quit();
#endif
    }
}
