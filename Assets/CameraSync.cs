using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSync : MonoBehaviour
{
    [SerializeField]
    GameObject originCamera;
    // Start is called before the first frame update
    private void Start()
    {
        originCamera = GameObject.FindGameObjectWithTag("Tracking");

        this.transform.rotation = originCamera.transform.localRotation;

    }
}
