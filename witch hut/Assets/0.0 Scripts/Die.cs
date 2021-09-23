using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class Die : MonoBehaviour
{
    private static float time = -1;
    public Transform player;
    public Transform grave;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1f;
        if (Input.GetKeyUp("4") && time <= -1 && Menu.isOpened == false && BookFQ.isOpened2 == false)
        {
            obj.GetComponent<HS_ArcherInput>().enabled = false;
            time = 20f;
            player.transform.position = grave.position;
            GetComponent<Canvas>().enabled = true;
        }
        else if (time == 0)
        {
            GetComponent<Canvas>().enabled = false;
            obj.GetComponent<HS_ArcherInput>().enabled = true;
        }
    }
}
