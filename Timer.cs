using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameManager GameManager;
    public Slider TimeSlider;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.mode == Mode.Play && timer < 100f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            GameManager.GameEnd();
        }
        TimeSlider.value = timer;
    }
}
