
using UnityEngine;

public partial class PlayerController
{
    public bool CheckForInput(out Vector3 movement)
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        return (movement.z == 1 || movement.x != 0) ? true : false;
    }
    
    public void Move(Vector3 movement)
    {
        if (movement.z == 0)
        {
            Idle();
            transform.Rotate(new Vector3(0, movement.x * Speed, 0));
        }
        else
        { 
            Rb.GetComponent<Animation>().CrossFade("run");
            transform.Rotate(new Vector3(0, movement.x * Speed, 0));
            Rb.velocity = transform.forward * Speed;
        }
    }


    public void Idle()
    {
        Rb.GetComponent<Animation>().CrossFade("idle");
        Rb.velocity = Vector3.zero;
    }
}

