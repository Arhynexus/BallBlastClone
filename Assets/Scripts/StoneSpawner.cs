using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StoneSpawner : MonoBehaviour
{

    [SerializeField] private Stone stonePrefab;
    [SerializeField] private Coin coinPrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Transform coinSpawner;         // ��������� � ��������� ������
    [SerializeField] private float spawnRate;
    [SerializeField] private int amount;

    [Space(10)] public UnityEvent CompletedSpawn;
    [HideInInspector] public UnityEvent ChangeColor;


    private float timer;
    private float amountSpawned;
    private Color spawnColor;
    private SpriteRenderer spawnRenderer;


    private void Awake()
    {
        ChangeColor.AddListener(SetSpawnColor);
    }

    void Start()
    {
        timer = spawnRate;
        spawnRenderer = stonePrefab.GetComponentInChildren<SpriteRenderer>();
    }

    private void SetSpawnColor()
    {
        spawnColor.r = Random.Range(0, 1f);                                       //���, � ��������
        spawnColor.g = Random.Range(0, 1f);                                       //������ ����
        spawnColor.b = Random.Range(0, 1f);                                       //��� ������ ������
        spawnColor = new Color(spawnColor.r, spawnColor.g, spawnColor.b, 1);      //���!!!
        spawnRenderer.color = spawnColor;                                         //
    }
    
    private void SpawnStone()
    {
        Stone stone = Instantiate(stonePrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
        stone.SetSize((Stone.Size) Random.Range(1,4));
        ChangeColor.Invoke();
        amountSpawned++;
    }

    private void SpawnCoin()                                                         //��������� � ��������� ������
    {                                                                                //��������� � ��������� ������
        Coin coin = Instantiate(coinPrefab, coinSpawner.transform.position, Quaternion.identity);//��������� � ��������� ������
    }                                                                                //��������� � ��������� ������

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnStone();
            //SpawnCoin();
            timer = 0;
        }
        if (amount == amountSpawned)
        {
            enabled = false;
            CompletedSpawn.Invoke();
        }
    }

    private void OnDestroy()
    {
        ChangeColor.RemoveListener(SetSpawnColor);
    }


}
