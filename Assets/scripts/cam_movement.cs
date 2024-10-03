using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Le personnage à suivre
    public Vector3 offset;   // Décalage entre la caméra et le personnage

    void Update()
    {
        if (target != null)
        {
            // Positionne la caméra à la position du personnage avec un décalage
            transform.position = target.position + offset;
        }
    }
}
