using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject player;
    private AudioSource _shotSound;
    private Rigidbody _rigidbody;
    
    void Start()
    {
        _shotSound = GetComponent<AudioSource>();
        var playerMaterial = CharacterMaterial.Instance;
        gameObject.GetComponent<MeshRenderer>().material = playerMaterial.characterMaterial[playerMaterial.materialRandomValue];
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = Vector3.forward * moveSpeed;
        Destroy(gameObject, 5f);
    }
}
