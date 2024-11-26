using UnityEngine;

public class FireOrb : MonoBehaviour
{   
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject projectile;
    public Transform projectileTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenShot;
    public int manaCost;
    public Mana mana;
    private int currentMana;

    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rotZ);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenShot)
            {
                canFire = true;
                timer = 0;
            }
        }

        if (Input.GetMouseButton(0) && canFire)
        {
            currentMana = mana.CheckMana();
            if(currentMana>= manaCost)
            {
                canFire = false;
                Instantiate(projectile, projectileTransform.position, Quaternion.identity);
                mana.UseMana(manaCost);
            }   

        }
    }
}
