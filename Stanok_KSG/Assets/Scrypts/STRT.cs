using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STRT : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftLamp;
    public GameObject RightLamp;
    public GameObject UpLamp;
    public GameObject DownLamp;
    void Start()
    {
        Renderer LeftRend = LeftLamp.GetComponent<Renderer>();
        Renderer RightRend = RightLamp.GetComponent<Renderer>();
        Renderer UpRend = UpLamp.GetComponent<Renderer>();
        Renderer DownRend = DownLamp.GetComponent<Renderer>();

        LeftRend.material.color = Color.green;
        RightRend.material.color = Color.green;
        UpRend.material.color = Color.green;
        DownRend.material.color = Color.green;
    }
}
