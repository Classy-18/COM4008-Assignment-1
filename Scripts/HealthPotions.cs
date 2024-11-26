using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthPotions : MonoBehaviour
{
    public int potionNum;
    public int healAmount;
    public TextMeshProUGUI potionText;
    public Health health;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Key was pressed");
            UsePotion();
        }
        potionText.text = potionNum.ToString();
    }
    public void PickupPotion()
        {
            potionNum += 1;
        }
    
    void UsePotion()
        {
            if (potionNum >= 1)
            {
                health.Heal(healAmount);
                potionNum -= 1;
            }
        }
    
}
