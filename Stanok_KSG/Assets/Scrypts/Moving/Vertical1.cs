using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DownLamp;

    public void OnTriggerEnter(Collider other)
    {
        Renderer DownRend = DownLamp.GetComponent<Renderer>();

        if (other.tag == "RezakInside")
        {
            DownRend.material.color = Color.red;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Renderer DownRend = DownLamp.GetComponent<Renderer>();

        if (other.tag == "RezakInside")
        {
            DownRend.material.color = Color.green;
        }
    }
}
