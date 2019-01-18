using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTutorialPopup_Tutorial : MonoBehaviour
{
    [SerializeField]
    GameObject TutorialLayout;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToGame()
    {
        Time.timeScale = 1.0f;
        TutorialLayout.SetActive(false);
    }
}
