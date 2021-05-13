using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public GameObject ball;
    public Transform eye;
    public GameObject theCamera;
    public Transform HandPos;
    // Start is called before the first frame update
    private void Update()
    {
      //  tr.position = Vector3.zero;
        if(OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
        
            CreateBall();
        }
    }
    

    public void CreateBall()
    {
     GameObject b=  Instantiate(ball, HandPos.position, HandPos.localRotation);
        //ball.GetComponent<>
        GameObject obja = Instantiate(theCamera, transform.position, eye.rotation);//카메라 생성
        MaterialCtrl mc = b.GetComponent<Ball>().mc;
        mc.SetInit();
        Debug.Log(mc.rt);
        obja.GetComponent<Camera>().targetTexture = mc.rt;
    }
    public void test()
    {


    }

}
