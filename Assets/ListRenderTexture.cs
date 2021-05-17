using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListRenderTexture : MonoBehaviour
{
    public static ListRenderTexture Instance
    {
        get; set;
    }
    public List<RenderTexture> listRT;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        listRT = new List<RenderTexture>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
