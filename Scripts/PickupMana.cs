using UnityEngine;

public class PickupMana : MonoBehaviour
{
    public int amount;
    public Mana mana;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            mana.RegenMana(amount);
            Destroy(gameObject);
        }
    }
}
