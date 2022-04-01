using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissCase : MonoBehaviour
{
        Transform case_transform;
    // Start is called before the first frame update
    void Start()
    {
        case_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        print("Мимо");
        Destroy(gameObject);
        case_transform.Translate(0.1f, 0, 0);
    }
}
