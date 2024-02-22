using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveStep = 1f;
    [SerializeField] Rigidbody2D _rigidbody;
    Vector3 currentPosition;
    Vector3 startingPosition;

    void Start()
    {
        // playerPosition = GetComponent<Rigidbody2D>().velocity;
        currentPosition = transform.position;
    }
    void Update()
    {

    }

    public void OnMove(InputValue value)
    {
        Vector2 inputVec = value.Get<Vector2>();
        _rigidbody.position += new Vector2(inputVec.x, inputVec.y) * moveStep;
    }

    // Set player position on x axis to be equal to river obstacle... so it moves
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.tag == "RiverObstacle")
        // {
        //     playerPosition.x +=
        //     other.GetComponent<Rigidbody2D>().velocity.x;
        // }
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log(currentPosition);
            SceneManager.LoadScene(0);
        }
    }

    // Rest frog on death and on win
    void ResetPosition()
    {
        startingPosition = new Vector3(0, -5f, 0);
        Debug.Log("Reset Position" + currentPosition);
        currentPosition = startingPosition;

    }




}

