using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(StoneMovement))]

public class Stone : Destructible
{
    public enum Size
    {
        Small,
        Medium,
        Large,
        Huge
    }
    
    [SerializeField] private Size size;
    [SerializeField] private float spawnUpForce;
    [SerializeField] private int damage;
    [SerializeField] private Coin coinPrefab;
    
    private StoneMovement movement;
    private int randomNumber;
    private int randomForCoinMax = 50;
    private int randomForCoinMin = 0;

    private void Awake()
    {
        movement = GetComponent<StoneMovement>();

        Die.AddListener(OnStoneDestroyed);

        SetSize(size);
    }

    private void OnDestroy()
    {
        Die.RemoveListener(OnStoneDestroyed);
    }

    private void SpawnStones()
    {
        for (int i = 0; i < 2; i++)
        {
            Stone stone = Instantiate(this, transform.position, Quaternion.identity);
            stone.SetSize(size - 1);
            stone.MaxHitPoints = Mathf.Clamp(MaxHitPoints / 2, 1, MaxHitPoints);
            stone.movement.AddVertivalVelocity(spawnUpForce);
            stone.movement.SetHorizontalDirection((i % 2 * 2) - 1);
        }

    }

    private void OnStoneDestroyed()
    {
        randomNumber = Random.Range(0, 100);
        if (size != Size.Small)
        {
            SpawnStones();
        }
        if (randomNumber >= randomForCoinMin && randomNumber <= randomForCoinMax)
        {
            Coin coin = Instantiate(coinPrefab, transform.position, Quaternion.identity);
            
        }
        Destroy(gameObject);
    }

    public void SetSize(Size size)
    {
        if (size < 0) return;
        transform.localScale = GetVectorFromSize(size);
        this.size = size;
    }

    private Vector3 GetVectorFromSize(Size size)
    {
        if (size == Size.Small) return new Vector3(0.4f,0.4f,0.4f);
        if (size == Size.Medium) return new Vector3(0.6f, 0.6f, 0.6f);
        if (size == Size.Large) return new Vector3(0.75f, 0.75f, 0.75f);
        if (size == Size.Huge) return new Vector3(1, 1, 1);
        return Vector3.zero;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destructible destructible = collision.transform.root.GetComponent<Destructible>();
        if (destructible != null)
        {
            destructible.ApplyDamage(damage);
        }
    }
}
