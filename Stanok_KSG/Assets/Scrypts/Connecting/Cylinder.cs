using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Cylinder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cylinder1;
    public GameObject CylinderOutside;

    public void OnTriggerEnter(Collider other)
    {
        Interactable interactable = CylinderOutside.GetComponent<Interactable>();

        if (other.tag == "Cylinder")
        {
            interactable.attachedToHand.DetachObject(CylinderOutside);
            CylinderOutside.SetActive(false);
            Cylinder1.SetActive(true);
        }
    }
}
