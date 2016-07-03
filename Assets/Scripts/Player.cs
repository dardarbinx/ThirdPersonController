
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rb { get; set; }

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
}

