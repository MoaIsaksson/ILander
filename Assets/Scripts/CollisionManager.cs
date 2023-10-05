using UnityEngine;

public class CollisionManager : MonoBehaviour {

    public Spaceship Movement;
    
    private void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.CompareTag($"Obstacle")) {
            
            Movement.enabled = false;
            FindObjectOfType<LoseWinScreen>().LoseGame();
            Debug.Log("We hit something");
            Debug.Log("GAME OVER");
        }

        if (collisionInfo.collider.CompareTag($"WinPlate"))
        {
            Movement.enabled = false;
            FindObjectOfType<LoseWinScreen>().WinGame();
            Debug.Log("YOU WON!");
        }
    }
}
