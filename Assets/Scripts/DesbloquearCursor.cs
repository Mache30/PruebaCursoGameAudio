using UnityEngine;

public class DesbloquearCursor : MonoBehaviour
{
    private void Start()
    {
        // Desbloquear el cursor del mouse.
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
