using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class BookFQ : MonoBehaviour
{
    public static bool isOpened2 = false;

    private int currResolutionIndex = 0;

    private static float time = 0;
    public GameObject obj2;
    public GameObject canvas2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Q) && time <= 0 && Menu.isOpened == false)
        {
            isOpened2 = !isOpened2;
            time = 20f;
        }
        else if (Input.GetKey(KeyCode.Escape) && isOpened2 == true && time <= 0)
        {
            isOpened2 = false;
            Menu.isOpened = false;
        }

        if (isOpened2 == true && Menu.isOpened == false)
        {
            //obj2.GetComponent<HS_CameraController>().enabled = false;
            canvas2.SetActive(false);
            GetComponent<Canvas>().enabled = isOpened2;
            time -= 1f;
        }
        else if (isOpened2 == false && Menu.isOpened == false)
        {
            GetComponent<Canvas>().enabled = isOpened2;
            //obj2.GetComponent<HS_CameraController>().enabled = true;
            canvas2.SetActive(true);
            time -= 1f;
        }
    }

    public void ShowHideMenu()
    {
        isOpened2 = !isOpened2;
        GetComponent<Canvas>().enabled = !isOpened2;
    }
}
