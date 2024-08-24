using UnityEngine;

public class CerrarJuego: MonoBehaviour
{
    // Este m�todo se llama cuando se presiona el bot�n.
    public void Cerrar()
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
