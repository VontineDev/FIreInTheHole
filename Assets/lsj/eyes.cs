using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyes : MonoBehaviour
{
    public Transform eyePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveRotate();
    }
    void MoveRotate()
    {
        //  Quaternion q = Quaternion.Euler(360f - eyePos.rotation.x, 360f - eyePos.rotation.y, 360f - eyePos.rotation.z);
     //   transform.eulerAngles =new Vector3(360f - Mathf.Abs(eyePos.eulerAngles.x), 360f - Mathf.Abs(eyePos.eulerAngles.y), 360f - Mathf.Abs(eyePos.eulerAngles.z));
    }
}
