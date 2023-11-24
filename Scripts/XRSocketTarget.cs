using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRSocketTarget : XRSocketInteractor
{
    public string targetTag;
    public Material correctObjHoverMaterial;
    public Material wrongObjHoverMaterial;

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        bool isCorrectItem = interactable.transform.tag == targetTag;

        // Set the hover mesh material based on whether it's the correct object
        MonoBehaviour hoverMonoBehaviour = interactable as MonoBehaviour;
        
        MeshRenderer hoverMeshRenderer = hoverMonoBehaviour.GetComponent<MeshRenderer>();
        if (hoverMeshRenderer != null)
        {
            hoverMeshRenderer.material = isCorrectItem ? correctObjHoverMaterial : wrongObjHoverMaterial;
        }

        return base.CanHover(interactable) && isCorrectItem;
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && interactable.transform.tag == targetTag;
    }

    [Obsolete("Use OnSelectEntered(SelectEnterEventArgs args) instead.")]
    protected override void OnSelectEntered(XRBaseInteractable interactable)
    {
        base.OnSelectEntered(interactable);

        // Freeze the object's position and rotation
        Rigidbody rb = interactable.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

        StartCoroutine(DisableGrabbableAfterDelay(interactable));

    }

    private IEnumerator DisableGrabbableAfterDelay(XRBaseInteractable interactable)
    {
        // Disable Object's isGrabbable after 1 second
        yield return new WaitForSeconds(0.1f);
        interactable.enabled = false;
    }

}
