using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float time;
    public Text textBox;
    
    public bool stop = false; 

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(!stop)
        {
            time += Time.deltaTime;
            textBox.text = Mathf.Round(time).ToString();
        }
    }
}
