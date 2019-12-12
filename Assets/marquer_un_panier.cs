using System;
using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.painting;
using UnityEngine;

public class marquer_un_panier : MonoBehaviour
{
    int score = 0;
  public void OnTriggerEnter(Collider other)
  {
        if (other.gameObject.CompareTag("ballon"))
        {
            score = score + 1;
            //score++;
            //score += 1;
            Debug.Log(score);
        }
  }
}
