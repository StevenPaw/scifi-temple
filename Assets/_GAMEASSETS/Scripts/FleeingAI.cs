 using System;
 using UnityEngine;
 using System.Collections;
 using UnityEngine.AI;

 public class FleeingAI : MonoBehaviour {
 
     private NavMeshAgent agent;
     private Transform player;
     [SerializeField] private int multiplier = 1; // or more
     [SerializeField] private float range = 30;
     private Animator animator;
     
     void Start() {
         agent = GetComponent<NavMeshAgent>();
         player = GameObject.FindGameObjectWithTag("Player").transform;
         animator = GetComponent<Animator>();
     }
     
     void Update() {
         Vector3 runTo = transform.position + ((transform.position - player.position) * multiplier);
         float distance = Vector3.Distance(transform.position, player.position);
         if (distance < range)
         {
             agent.SetDestination(runTo);
             animator.SetBool("isRunning", true);
         }
         else
         {
             agent.SetDestination(transform.position);
             animator.SetBool("isRunning", false);
         }
     }
 }