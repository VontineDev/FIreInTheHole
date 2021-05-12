using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PortalCtrl:MonoBehaviour
{
    /// <summary>
    /// 볼
    /// </summary>
    public GameObject ball;
    public Rigidbody ballRig;
    public MeshRenderer render;

    /// <summary>
    /// 포탈
    /// </summary>
    public GameObject portal;
    /// <summary>
    /// 생성될 거리크기
    /// </summary>
    public float distance;
    /// <summary>
    /// 플레이어 위치
    /// </summary>
    //public Transform player;
    public bool isCreate=false;
    // Start is called before the first frame update
   public void Updates()
    {
        if(isCreate)
        {
            return;
        }
        if (distance <= GetDistance())
        {
            Debug.Log("포탈생성");
            OffRenderer();
            isCreate = true;
        }
    }

    public float GetDistance()
    {
        return Vector3.Distance(Vector3.zero, ball.transform.position);
    }
    public void OffRenderer()
    {
        render.enabled = false;
        //   SetActiveObj(true, portal);
        portal.SetActive(true);
        ballRig.velocity = Vector3.zero;
    }
    
}
