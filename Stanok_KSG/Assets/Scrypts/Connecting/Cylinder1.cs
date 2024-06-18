using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Cylinder1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cylinder11;
    public GameObject Cylinder1Outside;

    public void OnTriggerEnter(Collider other)
    {
        Interactable interactable = Cylinder1Outside.GetComponent<Interactable>();

        if (other.tag == "Cylinder1")
        {
            interactable.attachedToHand.DetachObject(Cylinder1Outside);
            Cylinder1Outside.SetActive(false);
            Cylinder11.SetActive(true);
        }
    }
}
