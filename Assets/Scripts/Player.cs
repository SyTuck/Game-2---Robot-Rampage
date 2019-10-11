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
            armour -= (int)(amount / 2 + 0.5f);

            if (armour > 0)
            {
                healthDamage = (int)(amount / 2 + 0.5f);
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

    private void pickupHealth()
    {
        health += 50;
        if (health > 200)
        {
            health = 200;
        }
    }

    private void pickupArmour()
    {
        armour += 15;
    }

    private void pickupAssaultRifleAmmo()
    {
        ammo.AddAmmo(Constants.AssaultRifle, 50);
    }

    private void pickupPistolAmmo()
    {
        ammo.AddAmmo(Constants.Pistol, 20);
    }

    private void pickupShotgunAmmo()
    {
        ammo.AddAmmo(Constants.Shotgun, 10);
    }

    public void PickUpItem (int PickupType)
    {
        switch(PickupType)
        {
            case Constants.PickUpArmor:
                pickupArmour();
                break;
            case Constants.PickUpHealth:
                pickupAssaultRifleAmmo();
                break;
            case Constants.PickUpAssaultRifleAmmo:
                pickupAssaultRifleAmmo();
                break;
            case Constants.PickUpPistolAmmo:
                pickupPistolAmmo();
                break;
            case Constants.PickUpShotgunAmmo:
                pickupShotgunAmmo();
                break;
            default:
                Debug.LogError("Bad pickup type passed" + PickupType);
                break;
        }
    }

}
