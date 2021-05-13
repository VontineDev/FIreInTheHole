using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public GameObject ball;
    public Transform tr;
    public GameObject theCamera;
    // Start is called before the first frame update
    private void Update()
    {
      //  tr.position = Vector3.zero;
        if(OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Instantiate(theCamera, ball.transform.position, ball.transform.rotation);//카메라 생성
            CreateBall();
        }
    }
    

    public void CreateBall()
    {
        Instantiate(ball, transform.position, transform.rotation);
        //ball.GetComponent<>
    }
}
