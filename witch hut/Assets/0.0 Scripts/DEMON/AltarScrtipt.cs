﻿using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class AltarScrtipt : MonoBehaviour
{
    public GameObject quest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
        quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
    }
}
