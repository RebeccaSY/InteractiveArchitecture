using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject ObjectEnable;
    public GameObject ObjectDisable;
    //public GameObject ObjectSelect;

    void Start()
    {
        // Subscribe to the select event of Object
        // ObjectSelect.GetComponent<HoverHandler>().OnSelectEntered += OnSelectEntered;
    }

    void Update()
    {
        StartCoroutine(EnableObjectAAndDisableObjectBAfterDelay(3f)); // 3 seconds delay
    }

    IEnumerator EnableObjectAAndDisableObjectBAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Enable ObjectA and disable ObjectB
        if (ObjectEnable != null)
            ObjectEnable.SetActive(true);

        if (ObjectDisable != null)
            ObjectDisable.SetActive(false);
    }
}
