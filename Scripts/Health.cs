using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public  Animator animator;

    public int health; //set the current health of the player
    public int numOfHearts; //set the total health of the player

    public Image[] hearts;  //an array to put hearts in
    public Sprite fullHeart; 
    public Sprite emptyHeart;


    void Update(){
        for (int i = 0; i < hearts.Length; i++ ) {

            if(health > numOfHearts){
                health = numOfHearts; //stops the player from having more than the max number of hearts
            }

            if (i<health){  
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts){
                hearts[i].enabled = true; 
            } else {
                hearts[i].enabled = false;
            }

        }
    }

public void TakeDamage(int damage) 
    {
        health -= damage;
        animator.SetTrigger("Hurt");
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
public void ExtraHeart()
    {
        numOfHearts += 1;
    }
public void Heal(int healAmount)
    {
        health += healAmount;
    }
}
