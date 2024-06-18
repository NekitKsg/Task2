using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Rezuk;

    public GameObject LeftLamp;
    public GameObject RightLamp;
    public GameObject UpLamp;
    public GameObject DownLamp;

    public void OnTriggerStay(Collider other)
    {
        Renderer LeftRend = LeftLamp.GetComponent<Renderer>();
        Renderer RightRend = RightLamp.GetComponent<Renderer>();
        Renderer UpRend = UpLamp.GetComponent<Renderer>();
        Renderer DownRend = DownLamp.GetComponent<Renderer>();

        if(other.tag == "ButtonLeft" && LeftRend.material.color != Color.red)
        {
            Rezuk.transform.position += transform.right * 0.002f;
        }        
        if(other.tag == "ButtonRight" && RightRend.material.color != Color.red)
        {
            Rezuk.transform.position -= transform.right * 0.002f;
        }        
        if(other.tag == "ButtonUp" && UpRend.material.color != Color.red)
        {
            Rezuk.transform.position -= transform.forward * 0.002f;
        }        
        if(other.tag == "ButtonDown" && DownRend.material.color != Color.red)
        {
            Rezuk.transform.position += transform.forward * 0.002f;
        }
    }
}
