using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Player>() != null && collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Player>().PickUpItem(type);
            //GetComponentInParent<PickupSpawn>().PickupWasPickedUp();
            GameObject spawner = GameObject.Find("PickupSpawn");
            spawner.GetComponent<PickupSpawn>().PickupWasPickedUp();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("Pickup Walled");
            //this.gameObject.transform.position.Set(Random.Range(Constants.MinAreanaX, Constants.MaxAreanaX), 1.0f, Random.Range(Constants.MinAreanaZ, Constants.MaxAreanaZ));
            //Debug.Log(this.gameObject.transform.position.x);
            //D/ebug.Log(this.gameObject.transform.position.z);
            GameObject spawner = GameObject.Find("PickupSpawn");
            spawner.GetComponent<PickupSpawn>().PickupWasPickedUp();
            Destroy(this.gameObject);
        }

    }
}
