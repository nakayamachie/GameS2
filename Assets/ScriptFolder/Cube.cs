using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] Object cube;
    Vector3 itemPos = new Vector3(0.0f, 1.0f, 0.0f);

    void Start()
    {
        for (itemPos.z = 10.0f; itemPos.z < 105.0f; itemPos.z += 5.0f) 
        {
            Instantiate(cube, itemPos, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }

    
}
