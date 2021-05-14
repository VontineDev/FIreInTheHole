using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUi : MonoBehaviour
{
    public Camera viewCamera;

    void Update()
    {
        if (viewCamera != null)
        {
            this.transform.position = viewCamera.transform.position;
            this.transform.rotation = viewCamera.transform.rotation;

        }
    }
}
