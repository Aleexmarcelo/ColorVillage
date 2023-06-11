using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float parallaxStrength = 0.5f; // Controla a força do efeito parallax

    public Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += deltaMovement * parallaxStrength;
        lastCameraPosition = cameraTransform.position;
    }
}
