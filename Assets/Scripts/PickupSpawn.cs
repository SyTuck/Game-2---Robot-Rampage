using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pickups;

    private void Start()
    {
        spawnPickup();
    }

    void spawnPickup()
    {
        GameObject pickup = Instantiate(pickups[Random.Range(0, pickups.Length)]);
        pickup.transform.position = new Vector3(Random.Range(Constants.MinAreanaX, Constants.MaxAreanaX), 1.0f, Random.Range(Constants.MinAreanaZ, Constants.MaxAreanaZ)); ;//transform.position;
        pickup.transform.parent = pickup.transform;//transform;
    }

    public void PickupWasPickedUp()
    {
        StartCoroutine("respawnPickup");
    }

    IEnumerator respawnPickup()
    {
        yield return new WaitForSeconds(20);
        spawnPickup();
    }

}


