using UnityEngine;

public class PickupHeart : MonoBehaviour
{
    public Health numOfHearts;
    public Health health;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            numOfHearts.ExtraHeart();
            health.Heal(1);
            Destroy(gameObject);
        }
    }
}
