using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepNext : MonoBehaviour
{
    [SerializeField] GameObject[] conObjects;
    [SerializeField] GameObject[] newObjects;
    [SerializeField] GameObject[] disObjects;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // see if all conditions met
        bool isNext = true;
        for (int i = 0; i < conObjects.Length; i++)
        {
            if (!conObjects[i].activeSelf)
            {
                isNext = false;
                break;
            }
        }

        // if yes, set the next step active
        if (isNext)
        {
            StartCoroutine(DisCurrAfterDelay());
            StartCoroutine(NextStepAfterDelay());
            Debug.Log("NEXT STEP!");
        }
    }

    private IEnumerator NextStepAfterDelay()
    {
        // Enable next step objects after 0.3 second
        yield return new WaitForSeconds(0.01f);
        for (int j = 0; j < newObjects.Length; j++)
        {
            newObjects[j].SetActive(true);
        }
    }

    private IEnumerator DisCurrAfterDelay()
    {
        // Enable next step objects after 0.3 second
        yield return new WaitForSeconds(0.3f);
        for (int k = 0; k < disObjects.Length; k++)
        {
            disObjects[k].SetActive(false);
        }
    }
}
