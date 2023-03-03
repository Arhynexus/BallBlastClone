using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelState : MonoBehaviour
{
    [SerializeField] private Cart cart;
    [SerializeField] private StoneSpawner spawner;
    [SerializeField] private Destructible destructible;
    private int hitpoints;

    private float timer;
    private bool checkPassed;
    
    [Space(5)]
    public UnityEvent Passed;
    public UnityEvent Defeat;

    private void Awake()
    {
        spawner.CompletedSpawn.AddListener(OnSpawnCompleted);
        cart.CollisionStone.AddListener(OnCartCollisionStone);
    }

    private void OnDestroy()
    {
        spawner.CompletedSpawn.RemoveListener(OnSpawnCompleted);
        cart.CollisionStone.RemoveListener(OnCartCollisionStone);
    }

    private void OnSpawnCompleted()
    {
        checkPassed = true;
    }

    private void OnCartCollisionStone()
    {
        hitpoints = destructible.GetHitPoints();
        if (hitpoints <=0)
        {
            Defeat.Invoke();
        }

    }

    private void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > 0.5f)
        {
            if (checkPassed == true)
            {
                if (FindObjectsOfType<Stone>().Length == 0)
                {
                    Passed.Invoke();
                }
            }

            timer = 0;
        }
        
    }
}
