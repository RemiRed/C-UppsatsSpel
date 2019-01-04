using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector;


public class DieBitch : vMonoBehaviour
{


    public void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Player"))
        {

            vGameController gc = FindObjectOfType<vGameController>();

            other.transform.position = gc.spawnPoint.position;


        }

    }

}
