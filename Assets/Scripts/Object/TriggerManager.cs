using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Realtime;
using UnityEngine;
using TMPro;
public class TriggerManager : MonoBehaviour
{
    private AudioSource _explosionSound;
    //[SerializeField] private AudioClip explosionClip;

    private void Start()
    {
        _explosionSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ammo"))
        {
            PlayExplosionSound();
            UI.Instance.score += 1;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void PlayExplosionSound()
    {
        //_explosionSound.clip = explosionClip;
        _explosionSound.Play();
    }
}
