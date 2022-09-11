using UnityEngine;

public class startButton : MonoBehaviour
{
    [SerializeField] private moveSphere moveSphere;

    public void StartMovement()
    {
        moveSphere.isMoving = true;
    }
}
