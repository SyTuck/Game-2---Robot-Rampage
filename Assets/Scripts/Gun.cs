using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float fireRate;
    protected float lastFireTime;

    // Start is called before the first frame update
    void Start()
    {
        lastFireTime = Time.time - 10;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    protected void Fire()
    {
        GetComponentInChildren<Animator>().Play("Fire");
    }
}
