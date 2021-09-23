using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart1 : MonoBehaviour
{
    public static float timePause = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePause -= 1f;
        if (timePause == -3)
        {
            Menu.isOpened = true;
        }
    }
}
