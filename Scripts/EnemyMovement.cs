using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed; //the speed that the enemy moves with
    public int patrolDestination;

    // Update is called once per frame
    void Update()
    {
        if (patrolDestination == 0) //check which patrol point is heading to
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
            if(Vector2.Distance(transform.position, patrolPoints[0].position)<.2f)
            {
                patrolDestination = 1; //changes patrol point once one is reached
            }
        }
        if (patrolDestination == 1) //check which patrol point is heading to
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
            if(Vector2.Distance(transform.position, patrolPoints[1].position)<.2f)
            {
                patrolDestination = 0;
            }  
        }    
    }
}
