using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : Destructible
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float baseFireRate;
    private float defaultFireRate = 0.5f;

    [SerializeField] public int projectileAmount;
    [SerializeField] public int heal;
    [SerializeField] private float projectileInterval;

    private float timer;
    private float fireRateTimer;
    private int fireRateCounter = 5;
    private float fireRateCooldownStart;
    private float fireRateUpCooldown = 10;

    private float projectileTimer;
    private int projectileCounter = 5;
    private float projectileCooldownStart;
    private float projectileCooldown = 10;
    private int defaultProjectileAmount = 1;
    private int baseProjectileAmount;

    public float fireRate;


    protected override void Start()
    {
        base.Start();
        baseProjectileAmount = defaultProjectileAmount;
    }

    public void FireRateUpSkill()
    {
        fireRateTimer += Time.deltaTime;
        fireRateCooldownStart += Time.deltaTime;
        if (fireRateTimer > fireRateCounter)
        {
            baseFireRate = defaultFireRate;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha1) == true)
        {
            if (fireRateCooldownStart > fireRateUpCooldown)
            {
                fireRateTimer = 0;
                fireRateCooldownStart = 0;
                if (fireRateTimer < fireRateCounter)
                {
                    baseFireRate = fireRate;
                }
            }
        }
    }

    public void ProjectilesUpSkill()
    {
        projectileTimer += Time.deltaTime;
        projectileCooldownStart += Time.deltaTime;
        if (projectileTimer > projectileCounter)
        {
            baseProjectileAmount = defaultProjectileAmount;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) == true)
        {
            if (projectileCooldownStart > projectileCooldown)
            {
                projectileTimer = 0;
                projectileCooldownStart = 0;
                if (projectileTimer < projectileCounter)
                {
                    baseProjectileAmount = projectileAmount;
                }
            }
        }
    }




    void Update()
    {
        timer += Time.deltaTime;


        FireRateUpSkill();
        ProjectilesUpSkill();

        if (Input.GetKeyDown(KeyCode.Alpha2) == true)
        {
            Destructible destructible = gameObject.GetComponent<Destructible>();
            destructible.ApplyHeal(heal);
        }
    }

    private void SpawnProjectile()
    {
        float startPosX = shootPoint.position.x - projectileInterval * (baseProjectileAmount - 1 ) * 0.5f;

        for (int i = 0; i < baseProjectileAmount; i++)
        {
            Instantiate(projectilePrefab, new Vector3(startPosX + i * projectileInterval, shootPoint.position.y, shootPoint.position.z), transform.rotation);
        }
    }
    public void Fire()
    {
        if (timer >= baseFireRate)
        {

            SpawnProjectile();


            timer = 0;
        }
    }
}
