using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCtrl : MonoBehaviour
{
    private Material m;
    public Material materialA;
    public RenderTexture rt;
    // Start is called before the first frame update
    void Start()
    {
        //MeshRenderer mr = GetComponent<MeshRenderer>();
        //rt = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
        //rt.Create();
        //m.mainTexture = rt;
        //mr.material.CopyPropertiesFromMaterial(m);

    }
    public void SetInit()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        rt = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
        rt.Create();

        m = new Material(materialA);
        m.mainTexture = rt;
        mr.material=m;
    }

}
