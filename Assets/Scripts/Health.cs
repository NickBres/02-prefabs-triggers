using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] string triggerTagReduce = "Enemy";
    [SerializeField] string triggerTagIncrease = "health";

    public void TakeDamage()
    {
        if (health > 0)
        {
            health--;
        }
    }

    public void AddHealth()
    {
        health++;
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    private void OnTriggerEnter2D(Collider2D other) // 3D collision detection
    {
        Debug.Log(other.gameObject.tag);

        if (other.tag == triggerTagReduce)
        {
            TakeDamage();
        }
        else if (other.tag == triggerTagIncrease)
        {
            AddHealth();
            Destroy(other.gameObject); // Optional: Destroy health object after pickup
        }

        if (!IsAlive())
        {
            SceneManager.LoadScene("level-game-over");
        }
    }
}