using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;

//этот скрипт вешаем на непосредственно на камеру

public class DvigaemGribi : MonoBehaviour
{
    public int ID;
    public int layerObj;
    public bool memoryLayer;
    public float yObj;
    public string nameIgnore;
    public float hitPoint;
    public static float time = 0;
    public static int a = 0;

    RaycastHit hit;
    Ray ray;

    public GameObject obj;

    void Start()
    {
        memoryLayer = true;
    }

    void Update()
    {
        if (time > 0) { time -= Time.deltaTime; }
        else if (time <= 0) { a = 0; }
        Motionobject();
    }

    //проверка перетаскиваемых объектов осуществляется по ID в имени объекта
    void Motionobject()
    {
        //проверяем нажатие кнопки мышки
        if (Input.GetMouseButtonDown(0) && obj == null)
        {
            //задаем направление луча
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //пускаем луч бесконечной длинны и если попали куда то, то
            if (Physics.Raycast(ray, out hit, 4))
            {
                //проверяем есть ли в имени десятичные цифры
                var reg = @"[0-9]+";
                //GameObject.FindGameObjectWithTag("Item").GetComponent<Rigidbody>().isKinematic = false;
                //получаем имя того во что попал райкаст и убираем у него приставку ID
                nameIgnore = hit.collider.gameObject.name.Replace("ID", "");

                //Debug.Log("Regex.IsMatch(nameIgnore, reg) = " + Regex.IsMatch(nameIgnore, reg));

                if (int.TryParse(nameIgnore, out int num))
                //if (Regex.IsMatch(nameIgnore, reg))
                {
                    //Debug.Log("hit.collider.name = " + nameIgnore);

                    //и конвектируем в числовое значение
                    ID = Convert.ToInt32(nameIgnore);

                    if (ID != 1)
                    {
                        //запоминаем во что попали лучем, для дальнейшей работы с этим ГО
                        obj = hit.collider.gameObject;
                        //Debug.Log("1");
                        a = 1;
                        time = 0.2f;
                    }
                }
            }
        }
        //тут мы и будем перемещать наш ГО
        if (obj != null)
        {
            Ray();

            //ставим флаг что уже запомнили слой
            if (memoryLayer)
            {
                //запоминаем слой ГО
                layerObj = obj.layer;
                memoryLayer = false;
            }

            //делаем ГО проницаемым для луча, что бы перемещать его в точку падения луча на терейне
            obj.layer = 2;
            //Debug.Log("hit.point = " + hit.point);

            //присваиваем их объекту на который попал луч
            //перемещаем соответственно только по горизонтальным плоскостям,
            //new Vector3(0, 0.5f, 0); приподнимаем ГО что бы он не сидел в текстурах
            //если подставить за место hit.distance например 10, то ГО будет двигаться на растоянии 10
            obj.transform.position = ray.GetPoint(2) + new Vector3(0, 0.1f, 0);
            if(obj.GetComponent<Rigidbody>().useGravity == false) 
            {
                obj.GetComponent<Rigidbody>().useGravity = true;
            }

        }

        //если кнопка была отжата то перестаем работать с ГО и обнуляем переменную, возвращаем слой обратно какой был
        if ((Input.GetMouseButtonDown(0) && obj != null && a != 1) || (obj != null && obj.active == false))
        {
            if (obj != null)
            {
                time = 1;
                obj.layer = layerObj;
                memoryLayer = true;
                obj = null;
            }
        }
    }

    void Ray()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit);
    }
}