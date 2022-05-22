using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyCheer : MonoBehaviour
{
    public Animator animator;
    public bool cheer = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(Pose());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Pose()
    {
        while (true)
        {
            cheer = !cheer;
            yield return new WaitForSeconds(10);
            animator.SetBool("Cheer", cheer);
        }
    }
}
