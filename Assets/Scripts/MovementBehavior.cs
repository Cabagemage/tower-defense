using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.Image;


public class MovementBehavior : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private List<Transform> pointers;
    private int nextPosition;
    private int currentPosition;
    private float movementProgress = 0;
    private void MoveForward()
    {
        movementProgress += Time.deltaTime * speed;
        if(movementProgress >= 1)
        {
            movementProgress -= 1;
            currentPosition++;
            nextPosition++;
            if(currentPosition >= pointers.Count)
            {
                currentPosition = 0;
            }
            if (nextPosition >= pointers.Count)
            {
                currentPosition = pointers.Count - 1;
                nextPosition = 0;
            }
        }
        Debug.Log($"{movementProgress} forward");   
        transform.position = Vector3.Lerp(pointers[currentPosition].position, pointers[nextPosition].position, movementProgress);
 
    }

 
    // Start is called before the first frame update
    void Start()
    {
        nextPosition = 1;
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }
}
