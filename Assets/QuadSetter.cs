using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadSetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    internal void Init(Vector3 pos, Transform originCamTr, RenderTexture tex)
    {
        //Set renderTexture
        var meshrend = this.GetComponent<MeshRenderer>();
        meshrend.material = new Material(Shader.Find("Unlit/Texture"));
        //meshrend.material = new Material(Shader.Find("Standard"));
        meshrend.material.mainTexture = tex;

        transform.rotation = Quaternion.LookRotation(transform.position - originCamTr.position);
    }
}
