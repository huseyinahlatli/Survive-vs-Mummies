using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CharacterMaterial : MonoBehaviour
{
    [SerializeField] public Material[] characterMaterial;
    [HideInInspector] public int materialRandomValue;

    #region Singleton Class: CharacterMaterial

    public static CharacterMaterial Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    #endregion
    private void Start()
    {
        materialRandomValue = Random.Range(0, 4);
        gameObject.GetComponent<MeshRenderer>().material = characterMaterial[materialRandomValue];
    }
}
