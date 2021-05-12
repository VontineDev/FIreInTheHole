using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public GameObject ball;
    public Transform tr;
    public Dimension d1;
    public Dimension d2;
    // Start is called before the first frame update
    private void Update()
    {
      //  tr.position = Vector3.zero;
        if(OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            CreateBall();
        }
    }
    

    public void CreateBall()
    {
        Instantiate(ball, transform.position, transform.rotation);
        //ball.GetComponent<>
    }
}
