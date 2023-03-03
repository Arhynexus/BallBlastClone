using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovement : MonoBehaviour
{
    [SerializeField] private float gravity;
    [SerializeField] private float reboundSpeed;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float gravityOffset;

    private bool useGravity;
    
    private Vector3 velocity;
    private Vector3 position;
    private float rotationDirection;

    private void Awake()
    {
        velocity.x = -Mathf.Sign(transform.position.x) * horizontalSpeed;
        velocity.z = -(transform.position.z + 0.01f);
    }

    void Update()
    {
        TryEnabledGravity();
        Move();
    }

    private void TryEnabledGravity()
    {
        if(Mathf.Abs(transform.position.x) <= Mathf.Abs(LevelBoundary.Instance.LeftBorder) - gravityOffset)
        {
            useGravity = true;
        }
    }
    private void Move()
    {
        rotationDirection = -Mathf.Sign(velocity.x);
        if (useGravity == true)
        {
            velocity.y -= gravity * Time.deltaTime;
        }
        transform.Rotate(0, 0, rotationDirection * rotationSpeed * Time.deltaTime);
        velocity.x = Mathf.Sign(velocity.x) * horizontalSpeed;
        transform.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelEdge levelEdge = collision.gameObject.GetComponent<LevelEdge>();

        if (levelEdge != null)
        {
            if (levelEdge.Type == EdgeType.BottomEdge)
            {
                velocity.y = reboundSpeed;
            }

            if (levelEdge.Type == EdgeType.RightEdge && velocity.x >0 || levelEdge.Type == EdgeType.LeftEdge && velocity.x < 0)
            {
                velocity.x *= -1;
                rotationDirection *= -1;
            }
        }
    }

    public void AddVertivalVelocity(float velocity)
    {
        this.velocity.y += velocity;
    }

    public void SetHorizontalDirection (float direction)
    {
        velocity.x = Mathf.Sign(direction) * horizontalSpeed;
    }
}
