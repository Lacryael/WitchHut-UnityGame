using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class DemonRise : MonoBehaviour
{
    //private ParticleSystem demonRise;
    public GameObject quest;
    public GameObject demon;
    public GameObject demonItem1;
    public GameObject demonItem2;
    public GameObject demonItem3;
    public GameObject demonItem4;
    public GameObject demonItem5;
    public GameObject demonItem6;

    // Start is called before the first frame update
    void Start()
    {
        //demonRise = GameObject.Find("demonRise").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (demonItem1.activeSelf == true && demonItem2.activeSelf == true && demonItem3.activeSelf == true && demonItem4.activeSelf == true && demonItem5.activeSelf == true && demonItem6.activeSelf == true)
        {
            demon.SetActive(true);
            //demonRise.Play();
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
        }
    }
}
