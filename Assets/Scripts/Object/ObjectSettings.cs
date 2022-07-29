using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSettings : MonoBehaviour
{
    [SerializeField] private Material[] materialList;
    private int _randomMaterialValue;

    private void Start()
    {
        _randomMaterialValue = Random.Range(0, 7);
        gameObject.GetComponent<MeshRenderer>().material = materialList[_randomMaterialValue];
    }
}
