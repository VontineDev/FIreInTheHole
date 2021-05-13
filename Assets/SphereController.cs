using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroySelf());
    }
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(3f);
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
