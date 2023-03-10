using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    private float timer = 0.00f;
    private float endHour = 300.00f; //cinco minutos
    public float timeMultiplier = 1.00f; // permite acelerar o tempo no inspetor, pra ele nao fazer diferença tem que deixar em 1
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime * timeMultiplier;
        float seconds = timer % 60;
        Debug.Log(Mathf.RoundToInt(seconds));

        if (seconds > endHour && seconds < endHour + 0.01f)
        {
            timer = 0; //reseta o dia que é equivalente a passar pro proximo dia.
        }
    }

}


