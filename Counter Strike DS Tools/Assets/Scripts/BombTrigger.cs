using UnityEngine;

public class BombTrigger : MonoBehaviour
{
    [Header("Collider of the trigger")]
    public BoxCollider m_BoxCollider;
    [Header("Pathfinding point in the trigger")]
    public Point connectedPoint;

    /// <summary>
    /// Get the position of the trigger
    /// </summary>
    /// <returns>Position</returns>
    public Vector3 GetPosition()
    {
        Vector3 Pos = transform.position;
        Pos.x += m_BoxCollider.center.x;
        Pos.y += m_BoxCollider.center.y;
        Pos.z += m_BoxCollider.center.z;
        //Z axe is inverted on the DS
        Pos.z = -Pos.z;
        return Pos;
    }
}
