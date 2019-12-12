using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour {

    public float time;

    void Awake()
    {

    }


    void Update()
    {
        time -= Time.deltaTime;
        GetComponent<TMP_Text>().text = string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);
    }

    void TimerExecute()
    {
        Debug.Log("Timer");
    }
}