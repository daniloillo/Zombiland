using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMove : MonoBehaviour
{
    InputController inputController;
    Animator animator;
    CharacterController cc;

    //VARIABLES INPUT CONTROLLER
    bool agachado;
    Vector2 stickL;
    float triggerL;
    float triggerR;

    
    
    private void Awake()
    {
        inputController = new InputController();
        inputController.Movimiento.Saltar.started += ctx => { Saltar(); };
        //Agacharse
        inputController.Movimiento.Agacharse.started += ctx => agachado = true;
        inputController.Movimiento.Agacharse.canceled += ctx => agachado = false;
        //Caminar
        inputController.Movimiento.Moverse.performed += ctx => stickL = ctx.ReadValue<Vector2>();
        inputController.Movimiento.Moverse.canceled += ctx => stickL = Vector2.zero;
        //Strafe
            //Left
        inputController.Movimiento.Moverse.performed += ctx => triggerL = ctx.ReadValue<float>();
        inputController.Movimiento.Moverse.canceled += ctx => triggerL = 0f;
            //Right
        inputController.Movimiento.Moverse.performed += ctx => triggerR = ctx.ReadValue<float>();
        inputController.Movimiento.Moverse.canceled += ctx => triggerR = 0f;
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        cc = gameObject.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {   //Agacharse
        animator.SetBool("Agacharse", agachado);
        animator.SetFloat("Movimiento", stickL.y);
        //Strafe
        float strafe = triggerR - triggerL;
        print(triggerR);
        print(triggerL);

        animator.SetFloat("Strafe", strafe);

    }
    void Movimiento()
    {

    }
    void Saltar()
    { 
        

    }



    private void OnEnable()
    {
        inputController.Enable();
    }
    private void OnDisable()
    {
        inputController.Disable();
    }
}
