using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeUIText : MonoBehaviour
{
    public TMP_Text canvasText;
    public static int step_num;
    private GameObject currStep;

    // Start is called before the first frame update
    void Start()
    {
        ChangeUIText.step_num = 0;
        canvasText.text = "Welcome! \nHover and select to explore the interactive elements.\nWalk along the guided route!";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Step010") != null)
        {
            canvasText.text = "You've reached the end!";
            ArrowController.target = GameObject.Find("PlatformFuture").transform;
            Debug.Log("Step 10");
        }
        else if (GameObject.Find("Step009") != null)
        {
            canvasText.text = "Stand on the platform";
            ArrowController.target = GameObject.Find("PlatformFuture").transform;
            Debug.Log("Step 9");
        }
        else if (GameObject.Find("Step008") != null)
        {
            canvasText.text = "Follow the arrow\nTo operate the clock";
            ArrowController.target = GameObject.Find("pointer-target").transform;
            Debug.Log("Step 8");
        }
        else if (GameObject.Find("Step007") != null)
        {
            canvasText.text = "Transform the plant into architecture";
            ArrowController.target = GameObject.Find("GothicMini").transform;
            Debug.Log("Step 7");
        }
        else if (GameObject.Find("Step006") != null)
        {
            canvasText.text = "Enter the temple!\nChange the style of the model";
            ArrowController.target = GameObject.Find("RomanMini").transform;
            Debug.Log("Step 6");
        }
        else if (GameObject.Find("Step005") != null)
        {
            canvasText.text = "Stand beneath the birds!";
            ArrowController.target = GameObject.Find("Parrot-CircleFly").transform;
            Debug.Log("Step 5");
        }
        else if (GameObject.Find("Step004") != null)
        {
            canvasText.text = "Set the bird free!";
            ArrowController.target = GameObject.Find("Parrot-Idle").transform;
            Debug.Log("Step 4");
        }
        else if(GameObject.Find("Step003") != null)
        {
            canvasText.text = "Change the style of the whole model!";
            ArrowController.target = GameObject.Find("MiniModel").transform;
            Debug.Log("Step 3");
        }
        else if (GameObject.Find("Step002") != null)
        {
            canvasText.text = "Triger the bases with correct statues!";
            ArrowController.target = GameObject.Find("StatueAngel").transform;
            Debug.Log("Step 2");
        }
        else if (GameObject.Find("Step001") != null)
        {
            canvasText.text = "Click on the columns!";
            ArrowController.target = GameObject.Find("PantheonCentre").transform;
            Debug.Log("Step 1");
        }
        else if (GameObject.Find("Step000") != null)
        {
            canvasText.text = "Put the Statue on the chair!";
            ArrowController.target = GameObject.Find("statuech_1").transform;
            Debug.Log("Step 0");
        }

        /*else
        {
            canvasText.text = "You Finished!";
        }
        */
    }
}
