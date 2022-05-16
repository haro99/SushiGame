using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuthiScript : MonoBehaviour
{

    public Vector3 movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movespeed * Time.deltaTime;
    }
}
