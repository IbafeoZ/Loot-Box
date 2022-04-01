using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case_script : MonoBehaviour
{
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        score = score + 10000;
        print(" Ты заработал" + score + "$");
        Destroy(gameObject);
    }
}
