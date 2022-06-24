using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani : MonoBehaviour
{
    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown("z"))
        {
            ani.SetTrigger("Attack");
        }
    }
}
