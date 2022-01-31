using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMove : MonoBehaviour
{
    InputController inputController;
    Animator animator;
    CharacterController cc;
    [SerializeField] GameObject camera;
    

    //VARIABLES INPUT CONTROLLER
    bool agachado;
    Vector2 stickL;
    float triggerL;
    float triggerR;
    //VARIABLES CHARACTER CONTROLLER
    bool grounded;
    [SerializeField] float playerSpeed;
    bool strafelled;
    bool caminando;
    bool corriendo;
    
    
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
        inputController.Movimiento.StrafeL.performed += ctx => triggerL = ctx.ReadValue<float>();
        inputController.Movimiento.StrafeL.canceled += ctx => triggerL = 0f;
            //Right
        inputController.Movimiento.StrafeR.performed += ctx => triggerR = ctx.ReadValue<float>();
        inputController.Movimiento.StrafeR.canceled += ctx => triggerR = 0f;
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        cc = gameObject.GetComponent<CharacterController>();
        


    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        

    }
    void Movimiento()
    {   
        playerSpeed = 0.5f;
        //Agacharse
        animator.SetBool("Agacharse", agachado);
        //Caminar
        animator.SetFloat("Movimiento", stickL.y);
        //Vector Camara-Jugador
        Vector3 direccion = camera.transform.position - transform.position;


            //Movimiento
            if(!strafelled)
            {
                
            }
            else
            {
                caminando = false;

            }


        //LookAt

        
        
        //Strafe
        float strafe = triggerR - triggerL;        
        animator.SetFloat("Strafe", strafe);

            //Movimiento
            if (!caminando)
            {
                
            }
            else
            {
                strafelled = false;
            }
        if (corriendo)
        {

        }
        else if (strafelled)
        {   //Movimiento
            Vector3 strafeV = new Vector3(strafe, 0, 0);
            cc.Move(strafeV * Time.deltaTime * playerSpeed);
            
            //Animacion
            if (strafe < 0f || strafe > 0f)
            {
                animator.SetBool("StrafeBool", true);

            }
            else
            {
                animator.SetBool("StrafeBool", false);

            }
        }
        else //(Caminar)
        {   
            //Movimiento
            
            cc.Move(new Vector3 (direccion.x,0,direccion.z) * (-stickL.y) * Time.deltaTime * playerSpeed);
            
        }
            

            
               
            
        
        


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
