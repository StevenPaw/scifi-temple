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
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            if (canBeOpened)
            {
                doorAnimator.SetTrigger("Open");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){
            if (canBeOpened)
            {
                doorAnimator.SetTrigger("Close");
            }
        }
    }
}
