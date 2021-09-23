using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class SkelotonSay : MonoBehaviour
{
    public  float time = 400f;
    private static float time2 = 0;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        time2 -= Time.deltaTime;
        if (time2 <= 0)
        {
            obj.SetActive(false);
        }
    }
    void OnMouseDown()
    {
            obj.SetActive(true);
            time2 = time;
    }
}
