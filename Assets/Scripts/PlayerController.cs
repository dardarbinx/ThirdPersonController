using UnityEngine;


public partial class PlayerController : Player, IControllable
{
    private static Vector3 movement;
    public static Vector3 Movement
    {
        get { return movement; }
    }
    public float Speed;

    void FixedUpdate()
    {
        if (CheckForInput(out movement))
            Move(Movement);
        else
            Idle();
    }
}
