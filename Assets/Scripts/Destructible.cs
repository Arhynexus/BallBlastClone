using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    public int MaxHitPoints;

    private int hitPoints;

    private bool isDie = false;

    [HideInInspector] public UnityEvent Die;
    [HideInInspector] public UnityEvent ChangeHitPoints;


    protected virtual void Start()
    {
        hitPoints = MaxHitPoints;
        ChangeHitPoints.Invoke();
    }

    public void ApplyDamage(int damage)
    { 
        hitPoints -= damage;
        ChangeHitPoints.Invoke();

        if (hitPoints <= 0)
        {
            Kill();
        }
    }

    public void ApplyHeal(int heal)
    {
        hitPoints += heal;
        ChangeHitPoints.Invoke();

        if (hitPoints >= MaxHitPoints)
        {
            hitPoints = MaxHitPoints;
        }
    }

    public void Kill()
    {
        if (isDie == true) return;
        hitPoints = 0;

        isDie = true;
        ChangeHitPoints.Invoke();
        Die.Invoke();
    }

    public int GetHitPoints()
    {
        return hitPoints;
    }
}
