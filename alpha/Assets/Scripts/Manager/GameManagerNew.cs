using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GameLoader
/// </summary>
public class GameManagerNew : MonoBehaviour
{
    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
