using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public PlayerAction inputAction;

    //Singleton: creating an instance
    public static PlayerInputController controller;

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

  
    void Awake()
    {
        //instance
        if(controller == null)
        {
            controller = this;
        }

        inputAction = new PlayerAction();
    }

  
}
