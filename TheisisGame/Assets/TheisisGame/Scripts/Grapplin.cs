/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapplin : MonoBehaviour
{

    #region Variables
    [SerializeField] GameObject hookGun, destination;// destination ska sättas i ett annat script med raycast
    [SerializeField] LineRenderer rope;
    [SerializeField] float travelSpeed;
    public bool isHooking;


    #endregion

    #region Properties

    public bool IsHooking
    {
        get { return isHooking; }
        set { isHooking = value; }
    }

    public GameObject Destination
    {
        get { return destination; }
        set { destination = value; }
    }

    public LineRenderer Rope
    {
        get { return rope; }
        set { rope = value; }
    }

    #endregion

    #region Methods

    void Update()
    {
        if (isHooking) //Kommunicera med annat script
        {
            rope.SetPosition(0, hookGun.transform.position);
            hookGun.transform.LookAt(destination.transform);
            rope.enabled = true;
            transform.position = Vector3.Lerp(transform.position, destination.transform.position, travelSpeed);
            isHooking = false;

            //Ändra i annat script där destination tilldelas. rope.setposition(1, destination.transform.position);
            //När den ska sluta hooka fram rope.enabled = false där ni vill
        }
    }
    #endregion
}

