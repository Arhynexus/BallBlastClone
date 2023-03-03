using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{

    
    private int amountOfMoney = 1;
    private Vector3 velocity;
    private Coin coinPrefab;
    [SerializeField] private float gravity;
    private bool coinGravity = true;
    void Start()
    {
    }

    public void Move()
    {
        if (coinGravity == true)
        {
            velocity.y -= gravity * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
        }
    }

    void Update()
    {
        Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bag bag = collision.GetComponentInParent<Bag>();
        if (bag != null)
        {
            bag.AddCoins(amountOfMoney);
            bag.OnChangeCoins.Invoke();
            Destroy(gameObject);
        }
        LevelEdge levelEdge = collision.gameObject.GetComponent<LevelEdge>();

        if (levelEdge != null)
        {
            if (levelEdge.Type == EdgeType.BottomEdge)
            {
                coinGravity = false;
            }
        }
    }
}
