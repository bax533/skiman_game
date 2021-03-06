﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class tutorialManager_script : MonoBehaviour
{

    public Animator panelAnim;
    public GameObject panel, coverPanel, imgPanel;
    public Text content;

    void OnTriggerEnter(Collider col)
    {


        if (name == "image")
        {
            panel.SetActive(false);
            coverPanel.SetActive(true);
            imgPanel.SetActive(true);
        }
        else if(name == "special")
        {
            if (PlayerPrefs.GetInt("360withGrab") != 0)
            {
                content.text = Values.tutorialMessages["good"];
            }
            else
            {
                content.text = Values.tutorialMessages["bad"];
            }
            panel.SetActive(true);
            coverPanel.SetActive(true);
        }
        else
        {
            content.text = Values.tutorialMessages[name];
            panel.SetActive(true);
            coverPanel.SetActive(true);
        }

        this.gameObject.SetActive(false);
        Time.timeScale = 0;
        
    }

    public void OKButtonClick()
    {
        
        PlayerPrefs.SetInt("360withGrab", 0);

        imgPanel.SetActive(false);
        coverPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
