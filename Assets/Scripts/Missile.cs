using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 30.0f;
    public int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("deathTimer");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collider)
    {
        if ((collider.gameObject.GetComponent<Player>() != null) && (collider.gameObject.tag == "Player"))
        {
            collider.gameObject.GetComponent<Player>().TakeDamage(damage);
            Destroy(gameObject);
        }

    }

    IEnumerator deathTimer()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
