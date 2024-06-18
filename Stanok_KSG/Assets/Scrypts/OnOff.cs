using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject OnOffLamp;
    public GameObject Cylinder;

    public void OnTriggerEnter(Collider other)
    {
        Renderer OnOffLampRend = OnOffLamp.GetComponent<Renderer>();

        if(other.tag == "SwitchOnOff")
        {
            if(OnOffLampRend.material.color != Color.red)
            {
                OnOffLampRend.material.color = Color.red;
                return;
            }
            OnOffLampRend.material.color = Color.green;
        }
    }

    private void Update()
    {
        Renderer OnOffLampRend = OnOffLamp.GetComponent<Renderer>();

        if (OnOffLampRend.material.color == Color.green)
        {
            Cylinder.transform.Rotate(-100, 0, 0);
        }
    }
}
