using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWaterBalloon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("CreateWaterBalloon");

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            print($"PrimaryHandTrigger Down");

        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            print($"SecondaryHandTrigger Down");

        }
    }
}
