using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDestruction_Tutorial : MonoBehaviour
{
    [SerializeField]
    GameObject destructibleCoins;

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
        destructibleCoins.AddComponent<TimedObjectDestructor>();
    }
}
