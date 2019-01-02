using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Invector
{

    public class DieBitch : vMonoBehaviour
    {

        public vHealthController health;
        public vHealthController dummy;

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {

                health.currentHealth = 0f;

            }
            if (other.tag == "Player")
            {

                dummy.currentHealth = 0f;

            }

        }
    }
}