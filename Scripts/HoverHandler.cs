using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HoverHandler : XRSimpleInteractable
{
    public string targetTag;
    public Material highlightMaterial;
    private Material originalMaterial;

    protected override void Awake()
    {
        base.Awake();

        // Store the original material of the interactable
        var renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            originalMaterial = renderer.material;
        }
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);

        // Check if the tag matches the target tag
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag(targetTag);
        for (int i = 0; i < targetObjects.Length; i++)
        {
            var renderer = targetObjects[i].GetComponent<Renderer>();
            if (renderer != null && highlightMaterial != null)
            {
                targetObjects[i].GetComponent<Renderer>().material = highlightMaterial;
            }
        }

        /*
        if (gameObject.CompareTag(targetTag))
        {
            // Change the material to the highlight material
            var renderer = GetComponent<Renderer>();
            if (renderer != null && highlightMaterial != null)
            {
                renderer.material = highlightMaterial;
            }
        }*/
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);

        // Check if the tag matches the target tag
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag(targetTag);
        for (int i = 0; i < targetObjects.Length; i++)
        {
            var renderer = targetObjects[i].GetComponent<Renderer>();
            if (renderer != null && originalMaterial != null)
            {
                targetObjects[i].GetComponent<Renderer>().material = originalMaterial;
            }
        }

        /*
        if (gameObject.CompareTag(targetTag))
        {
            // Restore the original material
            var renderer = GetComponent<Renderer>();
            if (renderer != null && originalMaterial != null)
            {
                renderer.material = originalMaterial;
            }
        }*/
    }
}
