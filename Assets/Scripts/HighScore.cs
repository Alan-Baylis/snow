﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace COMP30019.Project2
{
    public class HighScore : MonoBehaviour
    {
        Text timeText;

        void Start()
        {
            timeText = GetComponent<Text>();
        }

        void Update()
        {
            timeText.text = "Best Time: " + PlayerPrefs.GetFloat("highscore").ToString("00.00");
        }
    }
}
