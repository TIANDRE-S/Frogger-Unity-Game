using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rigidbody.velocity = new Vector2(-moveSpeed, 0);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(gameObject);
        _rigidbody = GetComponent<Rigidbody2D>();
    }

}
