using UnityEngine;

public class DestroyWhenOutOfView : MonoBehaviour
{
    [SerializeField] private float offset = 1f; // Extra offset below the camera where the object gets destroyed

    private Camera mainCamera; // Reference to the main camera
    private float screenBottom; // Bottom edge of the camera in world space
    private float screenTop;

    void Start()
    {
        // Get the main camera
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Calculate the world position of the bottom edge of the camera
        screenBottom = mainCamera.transform.position.y - mainCamera.orthographicSize - offset;
        screenTop = mainCamera.transform.position.y + mainCamera.orthographicSize + offset;

        // Check if the object is below the camera
        if (transform.position.y < screenBottom || transform.position.y > screenTop)
        {
            Destroy(gameObject);
        }
    }
}