using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;

public class TimeMachine : MonoBehaviour
{

    public float dayr = 0.9849711f;
    public float nightr = 0.2225881f;
    public GameObject sun;
    public Material nightSkyBox;
    public Material daySkyBox;
    public GameObject obj;
    public GameObject obj2;
    void Start()
    {
        GameObject sun = GameObject.Find("DirectionalLight");
        sun.GetComponent<Light>().color = new Color(nightr, 0.5296113f, 0.7735849f);
    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        GameObject sun = GameObject.Find("DirectionalLight");
        if (sun.GetComponent<Light>().color.r == nightr)//Делаем день
        {
            sun.GetComponent<Light>().color = new Color(dayr, 1, 0.6650944f, 1);
            sun.GetComponent<Light>().intensity = 1.3f;
            RenderSettings.skybox = daySkyBox;
            obj.SetActive(true);
            obj2.SetActive(false);
        }
        
        else if (sun.GetComponent<Light>().color.r == dayr)//Делаем ночь
        {
            sun.GetComponent<Light>().color = new Color(nightr, 0.5296113f, 0.7735849f);
            sun.GetComponent<Light>().intensity = 1.2f;
            RenderSettings.skybox = nightSkyBox;
            Debug.Log(nightSkyBox);
            Debug.Log(daySkyBox);
            obj.SetActive(false);
            obj2.SetActive(true);
        }
    }
}
