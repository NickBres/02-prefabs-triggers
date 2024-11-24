using UnityEngine;

public class VerticalMovingBackground : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 2f; // Speed of vertical scrolling (set in the Inspector)
    private float height; // Height of the background image
    private Vector2 startPosition; // Original position of the background

    void Start()
    {
        // Store the initial position of the background
        startPosition = transform.position;

        // Get the height of the sprite using the SpriteRenderer bounds
        height = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        // Move the background downward
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;

        // Check if the background has scrolled far enough to need repositioning
        if (transform.position.y <= startPosition.y - height)
        {
            // Reset position to loop the background
            transform.position = new Vector2(transform.position.x, startPosition.y);
        }
    }
}