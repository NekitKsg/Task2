using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Controller1;
    public GameObject ControllerOutside;
    public GameObject Trigger;

    public void OnTriggerEnter(Collider other)
    {
        Interactable interactable = ControllerOutside.GetComponent<Interactable>();

        if (other.tag == "Controller")
        {
            interactable.attachedToHand.DetachObject(ControllerOutside);
            ControllerOutside.SetActive(false);
            Controller1.SetActive(true);
            Trigger.SetActive(false);
        }
    }
}
