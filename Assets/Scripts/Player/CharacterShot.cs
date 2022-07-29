using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShot : MonoBehaviour
{
    [SerializeField] private GameObject ammoPrefab;
    [SerializeField] private GameObject ammoPosition;
    
    private Vector3 _instantiateTransform;
 
    private void Update()
    {
        _instantiateTransform = ammoPosition.transform.position; 

        if (Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(Shot());
    }

    private IEnumerator Shot()
    {
        Instantiate(ammoPrefab, _instantiateTransform, Quaternion.identity);
        yield return new WaitForSeconds(0f); 
    }
}
