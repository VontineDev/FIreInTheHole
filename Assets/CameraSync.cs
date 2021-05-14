using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSync : MonoBehaviour
{

    public Transform originCameraTrasnfrom;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position + originCameraTrasnfrom.position;
        transform.rotation = originCameraTrasnfrom.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
