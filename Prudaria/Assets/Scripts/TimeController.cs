using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField] public float timeMultiplier;
    [SerializeField] public float startHour;
    [SerializeField] public TextMeshProUGUI timeText;
    public string endHour = "22:00";
    public DateTime currentTime;
    

    public enum Days
    {
        Segunda, Terça, Quarta, Quinta, Sexta
    }

    public Days currentDay;
    void Start()
    {
        currentTime = DateTime.Now.Date + TimeSpan.FromHours(startHour);
    }

    void Update()
    {
        UpdateTimeOfDay();
    }
    public void UpdateTimeOfDay()
    {
        currentTime = currentTime.AddSeconds(Time.deltaTime * timeMultiplier);
        timeText.text = currentTime.ToString("HH:mm"); //sugeriram colocar dentro de um if(texto != null) mas não entendi pq então não fiz
    }
}


