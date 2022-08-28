using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{


    private int start = 3;
    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        start += 1;
        Debug.Log($"{gameObject.name}" + ":" + $"{start}");

    }
}
