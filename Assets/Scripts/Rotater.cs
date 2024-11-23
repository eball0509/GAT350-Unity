using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float angle;
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(angle * Time.deltaTime, Vector3.up);
    }
}
