using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            transform.Translate(0, _speed, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(0, -_speed, 0);
        }
    }
}
