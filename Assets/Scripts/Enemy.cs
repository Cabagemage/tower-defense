using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;
    private float progress = 0;
    [SerializeField]
    private Transform pathStart;
    [SerializeField]
    private Transform pathEnd;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = pathStart.position;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO ?????????? ?? Courutine 
        if(transform.position != pathEnd.position)
        {

            progress += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(pathStart.position, pathEnd.position, progress);
        }
    }
}
