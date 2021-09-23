using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class MainDoorOpen : MonoBehaviour
{
    private ParticleSystem DoorBoom;
    public static float time = 0;
    public GameObject quest;

    void Start()
    {
        DoorBoom = GameObject.Find("DoorBoom").GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else if (time < 0)
        {
            GameObject.Find("MainDoor").transform.position = new Vector3(0, -500, 0);
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
            GameObject.Find("FoxMainDoor").transform.position = new Vector3(0, -500, 0);
            GameObject.Find("RavenMainDoor").transform.position = new Vector3(0, -500, 0);
            time = 0;
        }
    }

    void OnCollisionEnter(Collision myCollision)
    {
        // определение столкновения с двумя разноименными объектами
        if (myCollision.gameObject.name == "ID2")
        {
            // Обращаемся к тегу объекта с которым столкнулись  
            //Debug.Log("Hit the floor");
            GameObject.Find("ID2").SetActive(false);
            DoorBoom.Play();
            time = 3.2f;
        }
    }
}

