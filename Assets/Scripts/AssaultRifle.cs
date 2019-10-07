using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Gun
{
    override protected void Update()
    {
        base.Update();                              
        if ((Input.GetMouseButton(0)) && ((Time.time - lastFireTime) > fireRate))     //Assault rifle fires while button is held
        {
            lastFireTime = Time.time;
            Fire();
        }
    }
}
