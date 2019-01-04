using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector;



public class CheckPoint : MonoBehaviour
{



    public void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Player"))
        {

            vGameController gc = FindObjectOfType<vGameController>();

            gc.spawnPoint = this.transform;

            
        }

    }

}