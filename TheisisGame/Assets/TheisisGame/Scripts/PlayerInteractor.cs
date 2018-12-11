using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour {

	void Update () {

        //Om spelaren är inom range så ska nåt hända när man trycker på E.
        //if (<radius)
        if (Input.GetKeyUp(KeyCode.E))
        {
           // Interactables interactable = collider.GetComponent<Interactables>();
        }
	}
}
