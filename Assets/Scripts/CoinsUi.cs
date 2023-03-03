using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsUi : MonoBehaviour
{

    [SerializeField] private Text coinText;
    [SerializeField] private Bag bag;
    
    // Start is called before the first frame update
    void Awake()
    {
        bag.OnChangeCoins.AddListener(CoinsText);
    }

    public void CoinsText()
    {
        int coins = bag.coins;
        if (coins >= 1000)

            coinText.text = coins / 1000 + "K";
        else
            coinText.text = coins.ToString();
    }

    private void OnDestroy()
    {
        bag.OnChangeCoins.AddListener(CoinsText);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
