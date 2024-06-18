using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Motor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Motor1;
    public GameObject MotorOutside;
    public GameObject Trigger;

    public void OnTriggerEnter(Collider other)
    {
        Interactable interactable = MotorOutside.GetComponent<Interactable>();

        if (other.tag == "Motor")
        {
            interactable.attachedToHand.DetachObject(MotorOutside);
            MotorOutside.SetActive(false);
            Motor1.SetActive(true);
            Trigger.SetActive(true);
        }
    }
}
