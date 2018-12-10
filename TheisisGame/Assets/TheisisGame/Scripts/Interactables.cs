using UnityEngine;

public class Interactables : MonoBehaviour {
    public float radius = 2f;
    GameObject player;
    /*void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);   
    } */

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
