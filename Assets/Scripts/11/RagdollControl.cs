using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollControl : MonoBehaviour
{
    public Animator Animator;
    public Rigidbody[] AllRigidbodys;

    private void Awake()
    {
        for(int i=0; i < AllRigidbodys.Length; i++)
        {
            AllRigidbodys[i].isKinematic = true;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysical();
        }
    }

    public void MakePhysical()
    {
        Animator.enabled = false;
        for (int i=0; i<AllRigidbodys.Length; i++)
        {
            AllRigidbodys[i].isKinematic = false;
        }
    }
}
