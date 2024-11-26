using UnityEngine;

public class Potion : MonoBehaviour
{
    public HealthPotions potionNum;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            potionNum.PickupPotion();
            Destroy(gameObject);
        }
    }
}
