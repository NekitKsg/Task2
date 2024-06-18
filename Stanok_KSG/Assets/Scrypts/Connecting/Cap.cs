using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Cap : MonoBehaviour
{
    public GameObject Cap1;
    public GameObject CapOutside;

    public void OnTriggerEnter(Collider other)
    {
        Interactable interactable = CapOutside.GetComponent<Interactable>();

        if (other.tag == "Cap")
        {
            interactable.attachedToHand.DetachObject(CapOutside);
            CapOutside.SetActive(false);
            Cap1.SetActive(true);
        }
    }
}
