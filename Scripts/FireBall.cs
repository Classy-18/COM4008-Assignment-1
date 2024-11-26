using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    public float force;
    private Rigidbody2D rb;
    public int attackDamage;
    public LayerMask enemyLayers;
    private  Transform GetTransform;
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg; 
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {   
        Attack();
        Destroy(gameObject);
    }
    void Attack()
    {
        
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, 5, enemyLayers); //detect if the attack hits an enemy

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHP>().takeDamage(attackDamage);
        }
        Destroy(gameObject);
    }
}
