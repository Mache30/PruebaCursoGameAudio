using UnityEngine;

public class CerrarJuego: MonoBehaviour
{
    // Este método se llama cuando se presiona el botón.
    public void Cerrar()
    {
        
        // Comprueba si la aplicación se está ejecutando en el editor de Unity.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Si no estamos en el editor, cierra la aplicación.
        Application.Quit();
#endif
    }
}
