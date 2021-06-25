using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    [SerializeField] private bool canBeOpened;
    [SerializeField] private Animator doorAnimator;

    private void Start()
    {
        doorAnimator.SetTrigger("Close");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canBeOpened)
        {
            doorAnimator.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (canBeOpened)
        {
            doorAnimator.SetTrigger("Close");
        }
    }
}
