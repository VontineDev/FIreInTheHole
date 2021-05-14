using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField]
    OVRCameraRig OVRCameraRig;

    [SerializeField]
    GameObject quadPrefab;

    [SerializeField]
    Transform originalCameraTransform;
    [SerializeField]
    Transform World2;
    // Start is called before the first frame update
    void Start()
    {
        OVRCameraRig = FindObjectOfType<OVRCameraRig>();

        StartCoroutine(DestroySelf());
    }
    IEnumerator DestroySelf()
    {
        float time = 0;
        while (time < 5f)
        {
            time += Time.deltaTime;
            yield return null;
            if (Vector3.Distance(this.transform.position, OVRCameraRig.transform.position) > 15)
            {
                //var portal = Instantiate(portalPrefab);
                //var ps = portal.GetComponentInChildren<Portal>();
                //var dim = FindObjectsOfType<Dimension>();
                //ps.dimension1 = dim[1];
                //ps.dimension2 = dim[0];
                //portal.transform.position = this.transform.position;
                //portal.transform.LookAt(OVRCameraRig.transform);
                var quad = Instantiate(quadPrefab);
                quad.transform.position = this.transform.position;
                quad.transform.LookAt(OVRCameraRig.transform);
                //var cam = Instantiate(Camera.main,)

                break;
            }
        }
        // yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "World")
        {
            print("Sphere Triggered with World");
            print(this.transform.position);
        }
    }

}
