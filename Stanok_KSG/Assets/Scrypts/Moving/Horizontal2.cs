using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject RightLamp;

    public void OnTriggerEnter(Collider other)
    {
        Renderer RightRend = RightLamp.GetComponent<Renderer>();

        if (other.tag == "RezakInside")
        {
            RightRend.material.color = Color.red;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Renderer RightRend = RightLamp.GetComponent<Renderer>();

        if (other.tag == "RezakInside")
        {
            RightRend.material.color = Color.green;
        }
    }
}
