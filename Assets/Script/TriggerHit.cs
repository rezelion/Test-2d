using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHit : MonoBehaviour
{
    public Rigidbody2D _rB;
    public int JumpingForce;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        var enemy = collision.collider.GetComponent<EnemyHitPoint>();
        if (enemy)
        {
            _rB.AddForce(new Vector2(0, JumpingForce), ForceMode2D.Impulse);
            enemy.TakeHit(1);
        }

        
    }
}
