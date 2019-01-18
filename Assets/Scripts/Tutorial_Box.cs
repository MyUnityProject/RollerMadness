using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Box : MonoBehaviour
{

    
    [SerializeField]
    GameObject manager;
    [SerializeField]
    string Message = "This should never be seen. Please contact Game Developer if this happens";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        manager.GetComponent<Tutorial_Manager>().TutorialMessage(Message);
        GameObject.Destroy(gameObject);
    }
}
