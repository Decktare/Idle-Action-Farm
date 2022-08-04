using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutting : MonoBehaviour
{   
    [SerializeField] private Animator _animation;
    public static bool isPressed;
    void OnTriggerStay(Collider other)
    {
        if(isPressed)
        {
            Destroy(other.gameObject);
        }
    }

    public void OnClickCutButton()
    {
        isPressed = true;
        _animation.SetTrigger("SlashTrigger");
        _animation.SetBool("Slash", true);
    }
}
