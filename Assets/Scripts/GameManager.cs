using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [HideInInspector] public bool isGamePoused;

    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform[] spawnPoints;

    private GameObject player;

    

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        Camera.main.gameObject.SetActive(false);
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        var index = PlayerPrefs.GetInt("SpawnPointIndex");
        var spawnPoint = spawnPoints[index];
        player = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
    }

    public void RespawnPlayer()
    {
        var index = PlayerPrefs.GetInt("SpawnPointIndex");
        player.transform.position = spawnPoints[index].position;
    }

    public void ChangeSpawnPoint(int spawnPointIdex)
    {
        PlayerPrefs.SetInt("SpawnPointIndex", spawnPointIdex);
    }
}
