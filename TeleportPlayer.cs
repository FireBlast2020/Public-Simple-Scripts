using GorillaLocomotion;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour 
{
    public Transform tpPoint;

    public void OnTriggerEnter(Collider other)
    {
        Teleport(tpPoint.position);
    }

    public void Teleport(Vector3 tpPosition)
    {
        Player.Instance.lastHeadPosition = tpPosition;
        Player.Instance.lastRightHandPosition = tpPosition;
        Player.Instance.lastLeftHandPosition = tpPosition;

        Player.Instance.transform.position = tpPosition;
    }      
}

