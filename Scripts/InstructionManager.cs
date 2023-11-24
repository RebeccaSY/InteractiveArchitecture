using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InstructionManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 3;
    public GameObject Instruction;
    public InputActionProperty showButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            Instruction.SetActive(!Instruction.activeSelf);
            Instruction.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }

        Instruction.transform.LookAt(new Vector3(head.position.x, Instruction.transform.position.y, head.position.z));
        Instruction.transform.forward *= -1;
        
    }
}
