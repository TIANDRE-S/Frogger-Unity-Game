using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveStep = 1f;
    [SerializeField] Rigidbody2D _rigidbody;


    public void OnMove(InputValue value)
    {
        Vector2 inputVec = value.Get<Vector2>();
        _rigidbody.position += new Vector2(inputVec.x, inputVec.y) * moveStep;
    }




}

