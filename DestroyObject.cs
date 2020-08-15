using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float destroyObjectIn;
    void Start()
    {
        Destroy(gameObject, destroyObjectIn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
