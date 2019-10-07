using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    override protected void Update()
    {
        base.Update();                              
        if ((Input.GetMouseButtonDown(0)) && ((Time.time - lastFireTime) > fireRate))     //Shotgun and Pistol are semi-auto fire
        {
            lastFireTime = Time.time;
            Fire();
        }
    }
}
