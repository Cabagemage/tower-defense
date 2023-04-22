using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform gunAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gunAxis.LookAt(enemy.transform, Vector3.back);
    }
}
