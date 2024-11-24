using UnityEngine;
using TMPro; // Import TextMesh Pro namespace

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] Health playerHealth; // Reference to the Health script
    [SerializeField] TMP_Text healthText; // Reference to the TextMeshPro UI element

    void Update()
    {
        if (playerHealth != null && healthText != null)
        {
            // Update the TextMeshPro text to show the current health
            healthText.text = playerHealth.health.ToString();
        }
    }
}