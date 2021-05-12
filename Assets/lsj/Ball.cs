using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : PortalCtrl
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
       ballRig.AddForce(Vector3.forward * speed);
    }
    private void Update()
    {
        Updates();
    }

}
