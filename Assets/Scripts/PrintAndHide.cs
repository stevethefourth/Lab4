using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide: MonoBehaviour
{

    public Renderer rend;
    private int i = 3;
    private int randomNumber;
    
    // Start is called before the first frame update

    void Start()
    {
        int rnd = Random.Range(200, 251);
        randomNumber = rnd;
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log($"{gameObject.name}" + ":" + $"{i}");
        if (gameObject.tag == "Red" && i == 100) 
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == randomNumber)
        {
            rend.enabled = false;
        }
    }
}
