using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public  Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 1;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) //if left mouse button is pressed
            {
                Attack();
                nextAttackTime = Time.time + 1f/attackRate;
            }
        }
    }

    void Attack()
    {
        
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); //detect if the attack hits an enemy

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHP>().takeDamage(attackDamage);
        }
        animator.SetTrigger("Attack");
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange); //shows a circle around where the attack range is

    }
}
