using System;
using UnityEngine;
using Player;

public class InputReader : MonoBehaviour
{
    [SerializeField] private PlayerEntity _playerEntity;

    private float _horizontalInput;
    private float _verticalInput;
    
    private void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _playerEntity.Move(_horizontalInput, _verticalInput);
    }
}