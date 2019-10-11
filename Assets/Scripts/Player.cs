using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int armour;
    public GameUI gameUI;

    private GunEquipper gunEquipper;
    private Ammo ammo;

    // Start is called before the first frame update
    void Start()
    {
        ammo = GetComponent<Ammo>();
        gunEquipper = GetComponent<GunEquipper>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount) 
    {
        int healthDamage = amount;

        if (armour > 0)
        {
            armour  -= (int) (amount / 2 +0.5f);

            if (armour > 0)
            {
                healthDamage = (int) (amount / 2 + 0.5f);
            }
            else
            {
                armour = 0;
            }
        }

        health -= healthDamage;
        Debug.Log("Health is " + health);

        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
