using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Rezak : MonoBehaviour
{
    public GameObject Rezak1;
    public GameObject RezakOutside;

    public void OnTriggerEnter(Collider other)
    {
        Interactable interactable = RezakOutside.GetComponent<Interactable>();

        if (other.tag == "Rezak")
        {
            interactable.attachedToHand.DetachObject(RezakOutside);
            RezakOutside.SetActive(false);
            Rezak1.SetActive(true);
        }
    }
}
