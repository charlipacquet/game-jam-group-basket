using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramasse_la_baballe : MonoBehaviour
{
    public GameObject spawnballe;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !other.gameObject.GetComponentInParent<ProjectileStandard>())
        {
            Debug.Log("ramasse la balle " + other.gameObject.tag);
            Instantiate(spawnballe, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}   