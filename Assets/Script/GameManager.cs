using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefebs;
    private float currentDuration;
    public float timeToSpawn;
    public GameObject GameOverUI;
    private bool IsDeath;
    public Text Koin;
    [HideInInspector] public int KoinDiperoleh;



    void Start()
    {
        GameOverUI.SetActive(false);
    }

    void Update()
    {
        if (IsDeath)
        {
            return;
        }
        currentDuration += Time.deltaTime;
        if (currentDuration > timeToSpawn)
        {
            currentDuration = 0;
            Vector3 spawnPosition = transform.position;
            spawnPosition.z = Random.Range(spawnPosition.z -5, spawnPosition.z + 5);
            GameObject enemy = Instantiate(enemyPrefebs, spawnPosition, Quaternion.identity);
        }
    }

    public void GameOver()
    {
        Koin.text = KoinDiperoleh.ToString();
        GameOverUI.SetActive(true);
        IsDeath = true;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
