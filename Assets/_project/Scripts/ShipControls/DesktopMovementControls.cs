using System;
using UnityEngine;

[Serializable]
public class DesktopMovementControls : MovementControlsBase
{
    [SerializeField] float _deadZoneRadius = 0.1f;
    
    Vector2 ScreenCenter => new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

    public override float YawAmount
    {
        get
        {
            float yaw = Input.GetAxis("Horizontal");
            return Mathf.Abs(yaw) > _deadZoneRadius ? yaw : 0f;
        }
    }

    public override float PitchAmount
    {
        get
        {
            float pitch = Input.GetAxis("Vertical");
            return Mathf.Abs(pitch) > _deadZoneRadius ? pitch * -1: 0f;
        } 
        
    }

    public override float RollAmount
    {
        get
        {
            if (Input.GetButton("RollNeg"))
            {
                return 1f;
            }

            return Input.GetButton("RollPos") ? -1f : 0f;
        } 
        
    }

    public override float ThrustAmount
    {
        get
        {
            float pitch = Input.GetAxis("Vertical");
            return Mathf.Abs(pitch) > _deadZoneRadius ? pitch * -1: 0f;
        } 
        
    }
}