using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public Transform characterController;
    public Camera vrCamera;
    public static Transform target;

    void Update()
    {
        if (characterController != null && vrCamera != null)
        {
            // Set the arrow under Character Controller
            transform.position = new Vector3(characterController.position.x, characterController.position.y - 0.5f, characterController.position.z);
            Vector3 directionTo = target.position - transform.position;
            directionTo.y = 0f;

            // in front of camera
            //Stransform.LookAt(vrCamera.transform);
            transform.rotation = Quaternion.LookRotation(directionTo);
        }
    }
}
