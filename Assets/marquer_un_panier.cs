using System;
using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.painting;
using UnityEngine;
using TMPro;

public class marquer_un_panier : MonoBehaviour
{
    static public int score = 0;
    public TMP_Text textComponent;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ballon"))
        {
            score = score + 1;
            //score++;
            //score += 1;
            Debug.Log(score);
            textComponent.text = "Score :" + score;
        }
       
    }
}