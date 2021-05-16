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
    GameObject cameraPrefab;
    [SerializeField]
    Transform originalCameraTransform;
    [SerializeField]
    Transform World2;
    [SerializeField]
    RenderTexture copyRenderTexture;
    [SerializeField]
    Material materialPrefab;
    // Start is called before the first frame update
    void Start()
    {
        OVRCameraRig = FindObjectOfType<OVRCameraRig>();
        World2 = GameObject.FindGameObjectWithTag("World2").transform;

        StartCoroutine(DestroySelf());
    }
    IEnumerator DestroySelf()
    {
        float time = 0;
        while (time < 5f)
        {
            time += Time.deltaTime;
            yield return null;
            if (Vector3.Distance(this.transform.position, OVRCameraRig.transform.position) > 5)
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
                quad.transform.Rotate(0, 180f, 0);
                RenderTexture renderTexture = new RenderTexture(1024, 1024, 16, RenderTextureFormat.ARGB32);

                renderTexture.Create();
                var meshrend = quad.GetComponent<MeshRenderer>();
                meshrend.material = new Material(materialPrefab);
                meshrend.material.mainTexture = renderTexture;
                var camObject = Instantiate(cameraPrefab, World2.transform.position, World2.transform.rotation);
                var camera = camObject.GetComponent<Camera>();

                camera.targetTexture = renderTexture;
                camera.fieldOfView = 12f;
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
