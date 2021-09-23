using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    private static float time = -1;
    private int k = 0;
    public Transform player;
    public Transform portal;
    public GameObject obj;

    void Update()
    {
        time -= 1f;
        if (k == 1 && time <= -1)
        {
            time = 5f;
            obj.GetComponent<HS_ArcherInput>().enabled = false;
            player.transform.position = portal.position;
            k = 0;
        }
        else if (time == 0)
        {
            obj.GetComponent<HS_ArcherInput>().enabled = true;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        k = 1;
    }
}
