namespace Invector.vCharacterController
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class JumpPad : vMonoBehaviour
    {
        public GameObject playerController;
        public Rigidbody _rigidbody;
        public float jumpHeight = 2.7f;
        public float padStr = 4f;
        public vThirdPersonController v;
        public Animator anim;


        
        

        void OnTriggerEnter (Collider other)
        {

            if (other.tag == "Player")
            {
                _rigidbody = other.GetComponent<Rigidbody>();
                v = other.GetComponent<vThirdPersonController>();
                anim = other.GetComponent<Animator>();

                if (_rigidbody != null && v != null && anim != null)
                {


                    print("i get here");
                    var pad = _rigidbody.velocity;
                    pad.y = jumpHeight * padStr;
                    _rigidbody.velocity = pad;
                    anim.CrossFadeInFixedTime("Falling", 0.1f);
                }
            }


             
        }


        void OnTriggerExit(Collider otherEx)
        {
            if(otherEx.tag == "Player" && (v.isGrounded)  )
            {
                v.currentMultiJump = 0;
            }
        }
       
    }



}





