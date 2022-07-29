using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.AI;
public class AIMovement : MonoBehaviour
{ 
    [SerializeField] private Transform player;
    [CanBeNull] private NavMeshAgent _navMeshAgent;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(GetPlayerPosition());
    }

    void FixedUpdate()
    {
        _navMeshAgent.destination = player.GetChild(1).transform.position;
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private IEnumerator GetPlayerPosition()
    {
        yield return new WaitForSeconds(3f);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
}