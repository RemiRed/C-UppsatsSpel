using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Invector
{

    public class Grapplin : MonoBehaviour
    {


        // Update is called once per frame
        void Update()
        {
           /* if (_createRope) //Sets the ropes start position to the hookgun
            {
                _lr.SetPosition(0, transform.position); //Sets the ropes start position to the hookgun
                transform.LookAt(_destination.transform); //Makes the hookgun look at the target
                _lr.enabled = true;

                _player.transform.position = Vector3.Lerp(_player.transform.position, _destination.transform.position, _travelSpeed * Time.deltaTime); //Transports the players position to the goal position at desired speed

                float distanceToHook = Vector3.Distance(transform.position, _destination.transform.position); //Stores the distance between the hookgun and the destination

                if (distanceToHook <= _colliderOffset) //When the hookgun is “close enough” to the desired destination it removes the rope

                {
                    _lr.enabled = false;
                    _createRope = false;
                }
            }
            else
            {
                transform.rotation = Quaternion.identity;  //Resetting the hookgun rotation
            }*/
        }

    }
}
