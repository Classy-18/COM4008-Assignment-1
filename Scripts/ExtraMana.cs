using UnityEngine;

public class ExtraMana : MonoBehaviour
{
    public Mana mana;
    public Mana numOfOrbs;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            numOfOrbs.ExtraOrb();
            mana.RegenMana(1);
            Destroy(gameObject);
        }
    }
}
