using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Invector.vCharacterController
{
    public class BlinkScript : vMonoBehaviour
    {

        public float speed;
        private Rigidbody rb;
        public float cooldown;
        public float dashSpeed = 1.0f;
        private float coolDownTimer;
        public GenericInput rollInput = new GenericInput("Q", "B", "B");


        void Start()
        {
            rb = GetComponent<Rigidbody>();
            coolDownTimer = cooldown;
            print(coolDownTimer);

        }


        void Blink()
        {
            transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);
            
        }


        void FixedUpdate()
        {
            if (coolDownTimer > 0)
            {

                coolDownTimer -= Time.deltaTime;
            }
            if (coolDownTimer < 0)
            {

                coolDownTimer = 0;
            }


            if (rollInput.GetButton() && coolDownTimer == 0)
            {

                Blink();
                coolDownTimer = cooldown;
                print(coolDownTimer);
            }




        }

    }
}