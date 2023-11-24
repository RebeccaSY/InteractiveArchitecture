using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStepOnEnter : MonoBehaviour
{
    public GameObject objectToEnable;
    public Animator objectAnimator;
    public GameObject objectToDisable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // When the VR character controller entered the collider, enable the object
            if (objectToEnable != null)
            {
                objectToEnable.SetActive(true);
            }

            // enable the animation if there is one
            if (objectAnimator != null)
            {
                objectAnimator.enabled = true;
            }

            if (objectToDisable != null)
            {
                objectToDisable.SetActive(false);
            }
        }
    }
}

