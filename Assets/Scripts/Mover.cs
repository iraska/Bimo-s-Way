using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] float xValue;
    // [SerializeField] float yValue;
    // [SerializeField] float zValue;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // We are accesing the transform of this game object.
        // Translate() --> move; where do u want me to go on the X, Y, Z.
        // transform.Translate(1, 0, 0);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        // Calling MovePlayer()
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game:)");
        Debug.Log("Move your player with WASD or arrow keys.");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        // The player can be controlled with the keyboard -input-.
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // transform.Translate(0.01f, 0, 0);
        transform.Translate(xValue, 0, zValue);
    }
}
