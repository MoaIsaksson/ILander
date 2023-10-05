using UnityEngine;



public class Spaceship : MonoBehaviour {
    
    private void Update()
    {
        float moveSpeed = 5;
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(0, verticalInput, -horizontalInput) * (moveSpeed * Time.deltaTime));
    }
}