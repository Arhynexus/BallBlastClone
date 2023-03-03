using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{


    [SerializeField] private Turret turret;
    [SerializeField] private Bag bag;

    [SerializeField] private GameObject fireRateUpgrade;
    [SerializeField] private GameObject HealUpgrade;
    [SerializeField] private GameObject projectilesUpgrade;
    [SerializeField] private GameObject healthUpgrade;

    [SerializeField] private Text fireRateUpText;
    [SerializeField] private Text healUpgradeText;
    [SerializeField] private Text projectiliesUpgradeText;
    [SerializeField] private Text healthUpgradeText;

    private int costForFireRateUpBase = 5; //total 9 upgrades (5+10+15+20+25+30+35+40+45) = 225
    private int levelOfFireRate;
    private int costStepForFireRateUp = 5;
    private int costForFireRateUpTotal;
    private GameObject fireRateUpButton;
    private GameObject FilledUpgradeForFireRateUp;

    private int costForHealUpBase = 5;
    private int costStepForHealUp = 5;
    private int costForHealUpTotal;
    private int levelOfHealUp;
    private GameObject healUpButton;
    private GameObject FilledUpgradeForHealUp;

    private int costForProjectilesUpBase = 15;
    private int costStepForProjectilesUp = 15;
    private int levelOfProjectilesUp;
    private int costForProjectilesUpTotal;
    private GameObject projectilesUpButton;
    private GameObject FilledUpgradeforProjectilesUp;

    private int costForHealthUpBase = 5;
    private int costStepForHealthUp = 5;
    private int levelOfHealtUp;
    private int costForHealthUpTotal;
    private GameObject healthUpButton;
    private GameObject FilledUpgradeForHealthUp;



    
    private Cart cart;
    void Start()
    {
        bag = cart.GetComponent<Bag>();
        turret = cart.GetComponent<Turret>();
    }

    public void AddFireRate()
    {
        int coins = bag.coins;
        if (levelOfFireRate < 9)
        {
            if(coins >= costForFireRateUpTotal)
            {
                if (turret.fireRate <= 0.1f) turret.fireRate = 0.1f;
                turret.fireRate -= 0.04f;
                bag.RemoveCoins(costForFireRateUpTotal);
                levelOfFireRate++;
                if(levelOfFireRate == 1)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(1).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 2)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(2).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 3)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(3).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 4)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(4).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 5)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(5).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 6)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(6).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 7)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(7).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 8)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(8).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                }
                if (levelOfFireRate == 9)
                {
                    FilledUpgradeForFireRateUp = fireRateUpgrade.gameObject.transform.GetChild(9).GetChild(0).gameObject;
                    FilledUpgradeForFireRateUp.gameObject.SetActive(true);
                    fireRateUpButton = fireRateUpgrade.gameObject.transform.GetChild(0).gameObject;
                    fireRateUpButton.gameObject.GetComponent<Button>().enabled = false;
                    fireRateUpButton.gameObject.GetComponent<Image>().enabled = false;
                }
            }
        }
    }

    public void AddHeal()
    {
        int coins = bag.coins;
        if (levelOfHealUp < 9)
        {
            if (coins >= costForHealUpTotal)
            {
                bag.RemoveCoins(costForHealUpTotal);
                turret.heal += 1;
                levelOfHealUp++;
                if (levelOfHealUp == 1)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(1).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 2)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(2).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 3)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(3).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 4)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(4).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 5)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(5).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 6)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(6).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 7)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(7).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 8)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(8).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                }
                if (levelOfHealUp == 9)
                {
                    FilledUpgradeForHealUp = HealUpgrade.gameObject.transform.GetChild(9).GetChild(0).gameObject;
                    FilledUpgradeForHealUp.gameObject.SetActive(true);
                    healUpButton = HealUpgrade.gameObject.transform.GetChild(0).gameObject;
                    healUpButton.gameObject.GetComponent<Button>().enabled = false;
                    healUpButton.gameObject.GetComponent<Image>().enabled = false;
                }
            }
        }
    }

    public void AddProjectile()
    {
        int coins = bag.coins;
        if (levelOfProjectilesUp < 9)
        {
            if (coins >= costForProjectilesUpTotal)
            {
                bag.RemoveCoins(costForProjectilesUpTotal);
                turret.projectileAmount += 1;
                levelOfProjectilesUp++;
                if (levelOfProjectilesUp == 1)
                {
                    FilledUpgradeforProjectilesUp = projectilesUpgrade.gameObject.transform.GetChild(1).GetChild(0).gameObject;
                    FilledUpgradeforProjectilesUp.gameObject.SetActive(true);
                }
                if (levelOfProjectilesUp == 2)
                {
                    FilledUpgradeforProjectilesUp = projectilesUpgrade.gameObject.transform.GetChild(2).GetChild(0).gameObject;
                    FilledUpgradeforProjectilesUp.gameObject.SetActive(true);
                }
                if (levelOfProjectilesUp == 3)
                {
                    FilledUpgradeforProjectilesUp = projectilesUpgrade.gameObject.transform.GetChild(3).GetChild(0).gameObject;
                    FilledUpgradeforProjectilesUp.gameObject.SetActive(true);
                }
                if (levelOfProjectilesUp == 4)
                {
                    FilledUpgradeforProjectilesUp = projectilesUpgrade.gameObject.transform.GetChild(4).GetChild(0).gameObject;
                    FilledUpgradeforProjectilesUp.gameObject.SetActive(true);
                }
                if (levelOfProjectilesUp == 5)
                {
                    FilledUpgradeforProjectilesUp = projectilesUpgrade.gameObject.transform.GetChild(5).GetChild(0).gameObject;
                    FilledUpgradeforProjectilesUp.gameObject.SetActive(true);
                }
                if (levelOfProjectilesUp == 6)
                {
                    FilledUpgradeforProjectilesUp = projectilesUpgrade.gameObject.transform.GetChild(6).GetChild(0).gameObject;
                    FilledUpgradeforProjectilesUp.gameObject.SetActive(true);
                    projectilesUpButton = projectilesUpgrade.gameObject.transform.GetChild(0).gameObject;
                    projectilesUpButton.gameObject.GetComponent<Button>().enabled = false;
                    projectilesUpButton.gameObject.GetComponent<Image>().enabled = false;
                }
            }
        }
    }

    public void AddHealth()
    {
        int coins = bag.coins;
        if (levelOfHealtUp < 9)
        {
            if (coins >= costForHealthUpTotal)
            {
                bag.RemoveCoins(costForHealthUpTotal);
                turret.MaxHitPoints += 1;
                levelOfHealtUp++;
                if (levelOfHealtUp == 1)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(1).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 2)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(2).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 3)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(3).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 4)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(4).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 5)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(5).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 6)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(6).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 7)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(7).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 8)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(8).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                }
                if (levelOfHealtUp == 9)
                {
                    FilledUpgradeForHealthUp = healthUpgrade.gameObject.transform.GetChild(9).GetChild(0).gameObject;
                    FilledUpgradeForHealthUp.gameObject.SetActive(true);
                    healthUpButton = healthUpgrade.gameObject.transform.GetChild(0).gameObject;
                    healthUpButton.gameObject.GetComponent<Button>().enabled = false;
                    healthUpButton.gameObject.GetComponent<Image>().enabled = false;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        costForHealUpTotal = costForHealUpBase + (costStepForHealUp * levelOfHealUp);
        costForFireRateUpTotal = costForFireRateUpBase + (costStepForFireRateUp * levelOfFireRate);
        costForProjectilesUpTotal = costForProjectilesUpBase + (costStepForProjectilesUp * levelOfProjectilesUp);
        costForHealthUpTotal = costForHealthUpBase + (costStepForHealthUp * levelOfHealtUp);
        if (levelOfFireRate < 9)
        {
            fireRateUpText.text = "Цена: " + costForFireRateUpTotal;
        }
        if (levelOfFireRate == 9)
        {
            fireRateUpText.text = "Макс";
        }
        if (levelOfHealUp < 9)
        {
            healUpgradeText.text = "Цена: " + costForHealUpTotal;
        }
        if (levelOfHealUp == 9)
        {
            healUpgradeText.text = "Макс";
        }
        if (levelOfProjectilesUp < 9)
        {
            projectiliesUpgradeText.text = "Цена: " + costForProjectilesUpTotal;
        }
        if (levelOfProjectilesUp == 6)
        {
            projectiliesUpgradeText.text = "Макс";
        }
        if (levelOfHealtUp < 9)
        {
            healthUpgradeText.text = "Цена: " + costForHealthUpTotal;
        }
        if (levelOfHealtUp == 9)
        {
            healthUpgradeText.text = "Макс";
        }

    }
}
