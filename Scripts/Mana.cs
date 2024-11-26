using UnityEngine;
using UnityEngine.UI;

public class Mana : MonoBehaviour {

    public int mana; //set the current mana of the player
    public int numOfOrbs; //set the total mana of the player

    public Image[] orbs;  //an array to put orbs in
    public Sprite fullOrb; 
    public Sprite emptyOrb;
    

    void Update(){
        for (int i = 0; i < orbs.Length; i++ ) {

            if(mana > numOfOrbs){
                mana = numOfOrbs; //stops the player from having more than the max number of orbs
            }

            if (i<mana){  
                orbs[i].sprite = fullOrb;
            } else {
                orbs[i].sprite = emptyOrb;
            }

            if (i < numOfOrbs){
                orbs[i].enabled = true; 
            } else {
                orbs[i].enabled = false;
            }

        }
    }

public void UseMana(int cost) 
    {
        mana -= cost;
    }
public void RegenMana(int amount)
    {
        mana += amount;
    }
public void ExtraOrb()
    {
        numOfOrbs +=1;
    }
public int CheckMana() //checks if the player has enough mana
    { 
        return mana;
    }
}
