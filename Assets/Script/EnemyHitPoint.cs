using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitPoint : MonoBehaviour
{
    public float HP;
    public float MaxHP = 1;
    public HPBar Hbar;
    // Start is called before the first frame update
    void Start()
    {
        HP = MaxHP;
        Hbar.SetHP(HP, MaxHP);
    }

    public void TakeHit(float dmg)
    {
        HP -= dmg;
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
