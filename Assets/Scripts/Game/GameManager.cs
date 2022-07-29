using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] objectList;
    private float _randomPosition;
    
    private void Start()
    {
        StartCoroutine(CreateObject());
    }

    private IEnumerator CreateObject()
    {
        yield return new WaitForSeconds(4f);
        
        while (true)
        {
            InstantiateObject();
            yield return new WaitForSeconds(.5f);
        }
    }
    
    private void InstantiateObject()
    {
        _randomPosition = Random.Range(-13f, 14f);
        Instantiate(objectList[0], new Vector3(_randomPosition, 5, 12.5f), Quaternion.identity);
    }
}
