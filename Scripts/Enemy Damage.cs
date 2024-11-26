using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public Health health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player") //if the enemy touches the player 
        {
            health.TakeDamage(damage);  //player takes damage equal to a damage number which can be changed for each enemy
        }
    }
}
