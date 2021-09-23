using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;


public class OpenFireMag : MonoBehaviour
{
    private ParticleSystem witchFire;
    public static bool fireMagic = false;
    public GameObject quest;
    public GameObject ingredient1;
    public GameObject ingredient2;
    public GameObject ingredient3;
    public Sprite fireIcon;
    public Button fireButton;
    int a = 0;
    int b = 0;
    int c = 0;

    void Start()
    {
        witchFire = GameObject.Find("witchFire").GetComponent<ParticleSystem>();
        fireMagic = false;
    }

    void Update()
    {
        if (a == 1 && b == 1 && c == 1)
        {

            fireMagic = true;

            fireButton = GameObject.Find("Button 1").GetComponent<Button>();
            fireButton.image.sprite = fireIcon;

            witchFire.Play();
            ingredient1.transform.position = new Vector3(0, -500, 0);
            ingredient2.transform.position = new Vector3(0, -500, 0);
            ingredient3.transform.position = new Vector3(0, -500, 0);
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
        }
    }

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject == ingredient1) { a = 1;}
        if (myCollision.gameObject == ingredient2) { b = 1;}
        if (myCollision.gameObject == ingredient3) { c = 1;}
    }
    void OnCollisionExit(Collision myCollision)
    {
        if (myCollision.gameObject == ingredient1) { a = 0; }
        if (myCollision.gameObject == ingredient2) { b = 0; }
        if (myCollision.gameObject == ingredient3) { c = 0; }
    }
}
