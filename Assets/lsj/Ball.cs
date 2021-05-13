using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : PortalCtrl
{
    // Start is called before the first frame update
    public float speed;
    public MaterialCtrl mc;
    void Start()
    {
       ballRig.AddForce(transform.forward * speed);
    }
    private void Update()
    {
       // Updates();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "World")
        {
           Updates();
        }
    }

}
