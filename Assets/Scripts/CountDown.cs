using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text CountdownText;
    public GameObject TimeUpMenuUI;

    public float startingTime = 5.0f;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        TimeUpMenuUI.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        CountdownText.text = "Time: " + Convert.ToInt32(currentTime);

        if (currentTime <= 0.00f)
        {
            Time.timeScale = 0;
            TimeUpMenuUI.SetActive(true);
        }
    }
}
