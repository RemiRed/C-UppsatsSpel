using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsInteractable : MonoBehaviour {
    [SerializeField]
    private Image signText;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.E) || Input.GetButtonUp("Y"))
            signText.enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            signText.enabled = false;
    }
}