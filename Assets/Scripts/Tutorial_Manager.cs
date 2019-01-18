using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TutorialMessage(string Message)
    {
        GameObject TutorialLayout = gameObject.GetComponent<GameManager>().tutorialCanvas;
        Text TutorialDisplay = gameObject.GetComponent<GameManager>().tutorialScoreDisplay;
        Time.timeScale = 0.0f;
        TutorialLayout.SetActive(true);
        TutorialDisplay.text = Message;

    }
}
