using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Sushies;
    public Vector3 SetPosition;
    public float count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count>5f)
        {
            Instantiate(Sushies[Random.Range(0, Sushies.Length)], SetPosition, Quaternion.identity);
            Debug.Log("ŽõŽi‚ð”z’u‚µ‚Ü‚µ‚½");
            count = 0f;
        }
        else
        {
            count += Time.deltaTime;
        }
    }
}
