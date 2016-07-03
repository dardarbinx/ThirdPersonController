
using UnityEngine;

public interface IControllable
{
    bool CheckForInput(out Vector3 movement);
    void Move(Vector3 movement);
    void Idle();
}   

