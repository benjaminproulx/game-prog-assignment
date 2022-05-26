using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text timer;
    private int time = 0;
    void Start()
    {
        StartCoroutine(UpdateTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator UpdateTime()
    {
        while (true)
        {
            time += 1;
            timer.SetText("Time: " + time.ToString());
            yield return new WaitForSeconds(1);
        }
    }
}
