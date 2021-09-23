using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class OpenPortal : MonoBehaviour
{
    public static float time2 = 0;
    public GameObject obj;
    public GameObject obj2;
    public GameObject quest;
    public GameObject objDel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (time2 > 0)
        {
            objDel.transform.position = new Vector3(0, -500, 0);
            obj.SetActive(true);
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
            time2 = 0;
        }
    }
    void OnCollisionEnter(Collision myCollision)
    {
        // определение столкновения с двумя разноименными объектами
        if (myCollision.gameObject.name == "ID6")
        {
            // Обращаемся к тегу объекта с которым столкнулись  
            time2 = 2f;
            GameObject.Find("ID6").transform.position = new Vector3(0, -500, 0);
            obj2.transform.position = new Vector3(0, -500, 0);
        }

    }
}
