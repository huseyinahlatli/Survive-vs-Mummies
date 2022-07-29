using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class CharacterTrigger : MonoBehaviour
{
    [SerializeField] private GameObject hpText;
    [HideInInspector] public TextMeshPro textObject;
    private int _playerHp = 100;
    public bool characterDead = false;
    
    #region Singleton Class: CharacterTrigger

    public static CharacterTrigger Instance;    
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    
    #endregion

    public void Start()
    {
        textObject = GameObject.Find("HP Text").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mummy"))
        {
            if (_playerHp > 0)
            {
                _playerHp -= 2;
                Debug.Log("Player HP : " + _playerHp);
                textObject.text = "HP: %" + _playerHp.ToString();
            }
            else
            {
                textObject.text = "You Lost!";
                characterDead = true;
            }
        }
    }
}