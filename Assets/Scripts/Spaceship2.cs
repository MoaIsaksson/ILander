using UnityEngine;

public class Spaceship2 : MonoBehaviour {
    
    float _moveSpeed = 5;
    
    private void Update()
    {
        
        var horizontalInput = Input.GetAxis("Horizontal2");
        var verticalInput = Input.GetAxis("Vertical2");
        
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
