using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UpLamp;

    public void OnTriggerEnter(Collider other)
    {
        Renderer UpRend = UpLamp.GetComponent<Renderer>();

        if (other.tag == "RezakInside")
        {
            UpRend.material.color = Color.red;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Renderer UpRend = UpLamp.GetComponent<Renderer>();

        if (other.tag == "RezakInside")
        {
            UpRend.material.color = Color.green;
        }
    }
}
