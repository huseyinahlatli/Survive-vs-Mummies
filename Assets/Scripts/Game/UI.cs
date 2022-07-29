using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using static CharacterTrigger;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverText;
    [HideInInspector] public int score = 0;

    #region Singleton Class: UI

    public static UI Instance; 
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    #endregion


    private void Start()
    {
        StartCoroutine(IsGameOver());
    }

    private void Update()
    {
        scoreText.text = "Kill: " + score.ToString();
    }

    private IEnumerator IsGameOver()
    {
        yield return new WaitForSeconds(5f);
        
        while (true)
        {
            if (CharacterTrigger.Instance.characterDead == true)
            {
                gameOverText.SetActive(true);
                Time.timeScale = 0f;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void RestartGame()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadSceneAsync(0);
    }
}
