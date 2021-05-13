using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject OVROVRPlayerController;

    OVRGrabber leftHand;
    OVRGrabber rightHand;

    [SerializeField]
    GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        var hands = OVROVRPlayerController.GetComponentsInChildren<OVRGrabber>();

        leftHand = hands[0];
        rightHand = hands[1];

        StartCoroutine(CheckGrap());
    }



    IEnumerator CheckGrap()
    {
        while (true)
        {

            if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
            {
                SpawnBall(leftHand);
                print("PrimaryHandTrigger");
            }
            if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
            {
                SpawnBall(rightHand);
                print("SecondaryHandTrigger");
            }
            yield return new WaitForFixedUpdate();
        }
    }
    public void SpawnBall(OVRGrabber hand)
    {
        var ball = Instantiate(ballPrefab);
        ball.transform.position = hand.transform.position;
    }
}
