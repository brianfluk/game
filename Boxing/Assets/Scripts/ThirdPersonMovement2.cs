using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement2 : MonoBehaviour
{
    public Rigidbody rb;
    [Header(header:"Settings")] public float footSpeed;
    // public ForceMode appliedForceMode;

    private float _xMov;
    private float _zMov;

    void Update()
    {
        _xMov = Input.GetAxisRaw("Horizontal");
        _zMov = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(_xMov, rb.velocity.y, _zMov) * footSpeed * Time.deltaTime;
    }



}
