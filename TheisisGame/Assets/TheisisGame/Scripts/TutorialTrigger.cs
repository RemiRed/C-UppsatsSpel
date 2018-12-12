using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTrigger : MonoBehaviour {
    [SerializeField]
    private Image popUpText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            popUpText.enabled = true;

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            popUpText.enabled = false;

    }

}
