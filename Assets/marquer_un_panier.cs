using System;
using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.painting;
using UnityEngine;

public class marquer_un_panier : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ballon"))
        {
            Debug.Log("un pointdddd");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ballon"))
        {
            Debug.Log("un point");
        }
    }
}
