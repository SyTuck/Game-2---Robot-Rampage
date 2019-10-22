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
            gameUI.SetArmourText(armour);

            if (armour > 0)
            {
                healthDamage = (int)(amount / 2 + 0.5f);
            }
            else
            {
                armour = 0;
                gameUI.SetArmourText(armour);
            }
        }

        health -= healthDamage;
        Debug.Log("Health is " + health);

        if (health <= 0)
        {
            gameUI.SetHealthText(health);
        }
    }

    private void pickupHealth()
    {
        health += 50;
        if (health > 200)
        {
            health = 200;
        }

        gameUI.SetPickUpText("Health picked up +50 Health");
        gameUI.SetHealthText(health);
    }

    private void pickupArmour()
    {
        armour += 15;
        gameUI.SetPickUpText("Armour picked up +15 armour");
        gameUI.SetArmourText(armour);
    }

    private void pickupAssaultRifleAmmo()
    {
        ammo.AddAmmo(Constants.AssaultRifle, 50);
        gameUI.SetPickUpText("Assaut rifle ammo picked up +50 ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.AssaultRifle)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.AssaultRifle));
        }        
    }

    private void pickupPistolAmmo()
    {
        ammo.AddAmmo(Constants.Pistol, 20);
        gameUI.SetPickUpText("Pistol rifle ammo picked up +20 ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.Pistol)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.Pistol));
        }
    }

    private void pickupShotgunAmmo()
    {
        ammo.AddAmmo(Constants.Shotgun, 10);
        gameUI.SetPickUpText("Shotgun ammo picked up +10 ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.Shotgun)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.Shotgun));
        }
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
