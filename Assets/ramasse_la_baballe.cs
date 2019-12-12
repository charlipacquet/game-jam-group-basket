using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramasse_la_baballe : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ramasse la balle");
        }
    }
}
