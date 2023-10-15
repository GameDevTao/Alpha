using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var d = GetComponentsInChildren<BoxCollider>();
        Debug.LogError(d.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
