using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoving : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigitbody;
    [SerializeField] private FixedJoystick _fixedJoystick;
    [SerializeField] private Animator _animation;
    [SerializeField] private Transform _transformPlayer;

    [SerializeField] private float _moveSpeed;
    void Start()
    {
        
    }    
    void FixedUpdate()
    {
        _rigitbody.velocity = new Vector3(_fixedJoystick.Horizontal * _moveSpeed, _rigitbody.velocity.y, _fixedJoystick.Vertical * _moveSpeed);
        if ((_fixedJoystick.Vertical != 0 || _fixedJoystick.Horizontal != 0))
        {
            _animation.SetBool("Slash", false);
            _transformPlayer.transform.rotation = Quaternion.LookRotation(_rigitbody.velocity);
            _animation.SetBool("isWalk", true);
            Cutting.isPressed = false;
            
        }
        else
        {
            _animation.SetBool("isWalk", false);
        }
        
    }
}
