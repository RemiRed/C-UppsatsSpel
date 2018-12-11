using UnityEngine;
using System.Collections;

public class Interactables : MonoBehaviour {
    public float radius = 2f;
    public Transform tPlayer;
    public string playerTag = "Player";
    GameObject player;
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    
    void UpdatetPlayer()
    {
        GameObject.FindGameObjectsWithTag(playerTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestPlayer = null;
        float distanceToPlayer = Vector3.Distance(transform.position, tPlayer.transform.position);

        if (distanceToPlayer < shortestDistance)
        {
            shortestDistance = distanceToPlayer;
            nearestPlayer = player;
        }
        if(nearestPlayer != null && shortestDistance <= radius)
        {
            print("Read me!");
            tPlayer = nearestPlayer.transform;
        }
    }

    void Start()
    {
        InvokeRepeating("UpdatetPlayer", 0f, 0.5f);
    }
}
