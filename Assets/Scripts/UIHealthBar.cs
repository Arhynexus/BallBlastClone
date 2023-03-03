using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] private Destructible destructible;
    [SerializeField] private Image image;


    private void Start()
    {
        destructible.ChangeHitPoints.AddListener(OnChageHitPoints);
    }

    private void OnDestroy()
    {
        destructible.ChangeHitPoints.RemoveListener(OnChageHitPoints);
    }

    private void OnChageHitPoints()
    {
        image.fillAmount =(float) destructible.GetHitPoints() / (float) destructible.MaxHitPoints;
    }

    
}
