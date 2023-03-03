using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Destructible))]

public class StoneHitPointsText : MonoBehaviour
{
    [SerializeField] private Text hitpointText;

    private Destructible destructible;

    private void Awake()
    {
        destructible = GetComponent<Destructible>();
        destructible.ChangeHitPoints.AddListener(OnChangeHitpoints);
    }

    private void OnDestroy()
    {
        destructible.ChangeHitPoints.RemoveListener(OnChangeHitpoints);
    }

    private void OnChangeHitpoints()
    {
        int hitpoints = destructible.GetHitPoints();

        if (hitpoints >= 1000)
        
            hitpointText.text = hitpoints/1000 + "K";
        else
            hitpointText.text = hitpoints.ToString();
        
    }

}
