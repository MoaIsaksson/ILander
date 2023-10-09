using UnityEngine;

public class Spaceship : MonoBehaviour
{
    float _moveSpeed = 5;
    
    private void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(0, verticalInput, -horizontalInput) * (_moveSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider collisioninfo)
    {
        if (collisioninfo.CompareTag("Boost"))
        {
            _moveSpeed++;
        }
    }
}