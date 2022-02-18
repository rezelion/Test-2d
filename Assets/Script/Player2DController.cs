using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DController : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public float JumpingForce = 1f;
    private Rigidbody2D _rB;
    Vector2 Move;
    // Start is called before the first frame update
    void Start()
    {
        _rB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rB.velocity = new Vector2(Move.x * (MovementSpeed * 10) * Time.deltaTime, _rB.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.GetButtonDown("Jump") && Mathf.Abs(_rB.velocity.y) < 0.001f)
        {
            _rB.AddForce(new Vector2(0, JumpingForce), ForceMode2D.Impulse);
        }

        Move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    }
    
}
