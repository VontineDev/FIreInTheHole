using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    GameObject ui;

    bool isUi;

    void Start()
    {
        isUi = false;
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            if(isUi == false)
            {
                ui.SetActive(true);
                isUi = true;
            }
            else
            {
                ui.SetActive(false);
                isUi = false;
            }
            
        }
    }
}
