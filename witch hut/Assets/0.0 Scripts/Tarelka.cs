using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class Tarelka : MonoBehaviour
{
    public static float timeTarelka = 0;
    private ParticleSystem OpenBook;
    private ParticleSystem BookBoom;
    public GameObject book;
    public GameObject chika;
    public GameObject quest;
    // Start is called before the first frame update
    void Start()
    {
        OpenBook = GameObject.Find("OpenBook").GetComponent<ParticleSystem>();
        BookBoom = GameObject.Find("BookBoom").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeTarelka > 0)
        {
            timeTarelka -= Time.deltaTime;
        }
        if (timeTarelka < 0.2f && timeTarelka > 0)
        {
            BookBoom.Play();
        }
        if (timeTarelka < 0)
        {
            book.SetActive(true);
            quest.GetComponent<Text>().text = "- Покормить Лиса и получить книгу рецептов";
            quest.GetComponent<Text>().fontSize = 35;
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
            timeTarelka = 0;
        }
    }
    void OnCollisionEnter(Collision myCollision)
    {
        // определение столкновения с двумя разноименными объектами
        if (myCollision.gameObject.name == "ID089")
        {
            // Обращаемся к тегу объекта с которым столкнулись  
            GameObject.Find("ID089").SetActive(false);
            chika.SetActive(true);
            OpenBook.Play();
            timeTarelka = 2f;
        }

    }
}
