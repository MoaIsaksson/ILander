using UnityEngine;

public class Spaceship2 : MonoBehaviour {
    private void Update()
    {
        float moveSpeed = 5;
        var horizontalInput = Input.GetAxis("Horizontal2");
        var verticalInput = Input.GetAxis("Vertical2");
        
        transform.Translate(new Vector3(0, verticalInput, -horizontalInput) * (moveSpeed * Time.deltaTime));
    }
}
