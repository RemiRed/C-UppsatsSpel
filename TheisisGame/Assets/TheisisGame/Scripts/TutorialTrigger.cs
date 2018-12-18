using System.Collections;
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
            //Spelet pausas här.
        }

        else if (Input.GetKeyUp(KeyCode.E) && pauseState == true || Input.GetButtonUp("Y") && pauseState == true)
        {
            popUpText.enabled = false;
            print(pauseState);
            //Spelet fortsätter här.
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            popUpText.enabled = false;

    }

}
