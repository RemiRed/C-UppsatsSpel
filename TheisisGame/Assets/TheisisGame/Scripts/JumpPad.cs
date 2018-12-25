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


        void Start()
        {
            _rigidbody = playerController.GetComponent<Rigidbody>();            
        }
        

        void OnTriggerEnter (Collider other)
        {
            if (other.tag == "Player")
            {
                print("i get here");
                var pad = _rigidbody.velocity;
                pad.y = jumpHeight * padStr;
                _rigidbody.velocity = pad;
            }    
        }


        void OnTriggerExit(Collider otherEx)
        {
            if(otherEx.tag== "Player" && (v.isGrounded)  )
            {
                v.currentMultiJump = 0;
            }
        }
       
    }



}





//This script communicates with the player movement script
/*[SerializeField]
[Header("Only on speed boost")] float _speedBoost;
[SerializeField]
[Header("Only on jump pad")] float _springStrength;

void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player")
    {
        if (gameObject.tag == "JumpPad")
        {
            _pm.MoveDirection = new Vector3(0, _springStrength, 0); //Makes the player jump higher
        }

    }
}
void OnTriggerExit(Collider other) //Resetting the players speed
{
    if (other.tag == "Player" && gameObject.tag == "SpeedBoost")
    {
        _pm.AbleToSprint = true;
        _pm.Speed = _pm.NormalSpeed;
        _pm.Boosted = false;
    }
}*/