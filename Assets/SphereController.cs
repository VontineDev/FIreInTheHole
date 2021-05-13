using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField]
    OVRCameraRig OVRCameraRig;

    [SerializeField]
    GameObject portalPrefab;
    // Start is called before the first frame update
    void Start()
    {
        OVRCameraRig = FindObjectOfType<OVRCameraRig>();
        StartCoroutine(DestroySelf());
    }
    IEnumerator DestroySelf()
    {
        while (true)
        {
            yield return null;
            if (Vector3.Distance(this.transform.position, OVRCameraRig.transform.position) > 10)
            {
                var portal = Instantiate(portalPrefab);
                var ps = portal.GetComponentInChildren<Portal>();
                var dim = FindObjectsOfType<Dimension>();
                ps.dimension1 = dim[1];
                ps.dimension2 = dim[0];
                portal.transform.position = this.transform.position;
                portal.transform.LookAt(OVRCameraRig.transform);

                break;
            }
        }
        yield return new WaitForSeconds(5f);
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
