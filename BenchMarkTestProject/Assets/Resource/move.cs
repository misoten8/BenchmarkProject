using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

   // bool Flags = true ;

    private Animator animator;
    // Use this for initialization
    int mode = 0;
    int sec  = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("run", true);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("up"))
        //{
        //    transform.position += transform.forward * 0.01f;
        //    animator.SetBool("run", true);
        //}
        //else
        //{
        //    animator.SetBool("run", false);
        //}
        switch (mode)
        {
            case 0:
                if (sec < (5 * 60))
                {
                    mode = 1;
                }
                break;
            case 1:

                transform.Rotate(0, -0.1f, 0);
                if (sec < (3 * 60))
                {
                    mode = 2;
                }
                break;
            case 2:
                if (sec < (5 * 60))
                {
                    mode = 3;
                }
                break;
            case 3:
                transform.Rotate(0, -0.1f, 0);
                if (sec < (2 * 60))
                {
                    mode = 4;
                }
                break;
            case 4:
                transform.Rotate(0, 0.1f, 0);
                if (sec < (4 * 60))
                {
                    mode = 0;
                }
                break;
                
        }

        transform.position += transform.forward * 0.01f;
        sec++;

    }
}

