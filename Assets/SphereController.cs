using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class SphereController : MonoBehaviour
{
    [SerializeField]
    OVRCameraRig OVRCameraRig;
    [SerializeField]
    Transform origiCamTr;
    [SerializeField]
    Transform World2;
    // Start is called before the first frame update
    void Start()
    {
        OVRCameraRig = FindObjectOfType<OVRCameraRig>();
        World2 = GameObject.FindGameObjectWithTag("World2").transform;

        origiCamTr = GameObject.FindGameObjectWithTag("MainCamera").transform;

        StartCoroutine(DestroySelf());
    }
    IEnumerator DestroySelf()
    {
        float time = 0;
        while (time < 7f)
        {
            time += Time.deltaTime;
            yield return null;
            if (Vector3.Distance(this.transform.position, OVRCameraRig.transform.position) > 5)
            {

                RenderTexture renderTexture = new RenderTexture(512, 512, 16, RenderTextureFormat.ARGB32);
                renderTexture.Create();
                ListRenderTexture.Instance.listRT.Add(renderTexture);
                if (renderTexture.IsCreated())
                {
                    //Make Quad
                    var quadGo = GameObject.CreatePrimitive(PrimitiveType.Quad);
                    quadGo.transform.position = this.transform.position;
                    var quad = quadGo.AddComponent<QuadSetter>();
                  
                    var savePos = quad.transform.position;
                    var cameraGo = new GameObject("Camera");
                    var camera = cameraGo.AddComponent<Camera>();
                    camera.transform.position = World2.transform.position;
                    var pos = camera.transform.position + savePos;
                    print($"{pos}  Cameara Look AT");
                    camera.transform.LookAt(pos);
                    camera.targetTexture = renderTexture;
                    camera.fieldOfView = 12.2f;

                    quad.Init(this.transform.position, origiCamTr, renderTexture);

                }
                break;
            }
        }
        Destroy(this.gameObject);
    }
    private Texture2D RenderTextureTo2DTexture(RenderTexture rt)
    {
        var texture = new Texture2D(rt.width, rt.height, rt.graphicsFormat, 0, TextureCreationFlags.None);
        RenderTexture.active = rt;
        texture.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        texture.Apply();

        //RenderTexture.active = null;

        return texture;
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "World")
    //    {
    //        print("Sphere Triggered with World");
    //        print(this.transform.position);
    //    }
    //}

}
