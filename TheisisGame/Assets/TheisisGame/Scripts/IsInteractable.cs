using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsInteractable : MonoBehaviour {
    [SerializeField]
    private Image signText;
    bool showing = false;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.E) && showing == false || Input.GetButtonUp("Y") && showing == false)
        {
            signText.enabled = true;
            showing = true;
        }

        else if (Input.GetKeyUp(KeyCode.E) && showing == true || Input.GetButtonUp("Y") && showing == true)
        {
            signText.enabled = false;
            showing = false;
        }
       

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            signText.enabled = false;
    }
}