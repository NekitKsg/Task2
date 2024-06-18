using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftLamp;

    public void OnTriggerEnter(Collider other)
    {
        Renderer LeftRend = LeftLamp.GetComponent<Renderer>();

        if(other.tag == "RezakInside")
        {
            LeftRend.material.color = Color.red;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Renderer LeftRend = LeftLamp.GetComponent<Renderer>();

        if (other.tag == "RezakInside")
        {
            LeftRend.material.color = Color.green;
        }
    }
}
