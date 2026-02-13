using UnityEngine;

public class OriginalToTarget : MonoBehaviour
{
    [SerializeField] private Transform _original;
    [SerializeField] private Transform _target;

    private void Start ()
    {
        Vector3 displacementToTarget = new Vector3(1,0,-7) + _original.position;
        _original.position += displacementToTarget;
        Debug.Log(_target.position);
    }
}