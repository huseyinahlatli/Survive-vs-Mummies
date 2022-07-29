using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private PhotonView view;
    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private float moveSpeed;
    private Rigidbody _rigidbody;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");
            var movement = new Vector3(moveHorizontal, 0, moveVertical);
            _rigidbody.velocity = movement * moveSpeed;
        }
    }
}