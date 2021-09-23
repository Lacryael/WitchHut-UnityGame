using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class DemonItemAdd : MonoBehaviour
{
    public GameObject demon;
    public GameObject demonItemReal;
    public GameObject demonItemActivator;
    public GameObject demonItemGhost;

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject == demonItemActivator)
        {
            demonItemGhost.SetActive(false);
            demonItemReal.SetActive(true);
            demonItemActivator.SetActive(false);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
    }
}
