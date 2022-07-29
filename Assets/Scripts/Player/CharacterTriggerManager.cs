using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class CharacterTriggerManager : MonoBehaviour
{
    [SerializeField] private GameObject hpText;
    private int playerHp = 100;
    
    private void OnColliderEnter(Collider other)
    {
        Debug.Log("Player Collision is OK");
        
        if (other.gameObject.CompareTag("Mummy"))
        {
            
            if (playerHp >= 0)
            {
                playerHp -= 10;
                GetComponentInChildren<TextMeshProUGUI>().text = "%" + playerHp.ToString();
            }
            else
                GetComponentInChildren<TextMeshProUGUI>().text = "You Lost!";
        }
    }
}
