using UnityEngine;

public class EnemyHP : MonoBehaviour
{
   
   public int maxHealth;
   int currentHealth;
   public int manaDropped; 
   public GameObject ManaOrb;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Died!");
        Destroy(gameObject);
        Instantiate(ManaOrb, transform.position, Quaternion.identity);

    }
}
