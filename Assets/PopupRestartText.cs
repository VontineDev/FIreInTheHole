using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupRestartText : MonoBehaviour
{
    [SerializeField]
    Text restartText;
    // Start is called before the first frame update
    void Start()
    {
        restartText.gameObject.SetActive(false);

    }

    private void FixedUpdate()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            restartText.gameObject.SetActive(true);
        }
    }
}
