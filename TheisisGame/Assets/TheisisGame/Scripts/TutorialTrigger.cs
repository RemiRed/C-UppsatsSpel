﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTrigger : MonoBehaviour {
    bool pauseState = false;
    [SerializeField]
    private Image popUpText;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            popUpText.enabled = true;
            pauseState = true;
            print(pauseState);
            Time.timeScale = 0;
                
            //Spelet pausas här.

        }

        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyUp(KeyCode.E) && pauseState == true && Time.timeScale == 0 || other.CompareTag("Player") && Input.GetButtonUp("Y") && pauseState == true && Time.timeScale == 0)
        {
            popUpText.enabled = false;
            pauseState = false;
            print(pauseState);
            Time.timeScale = 1;
            //Spelet fortsätter här.


            Destroy(gameObject);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            popUpText.enabled = false;

    }

}
