using UnityEngine;

public class GameScript : MonoBehaviour
{
    
        
        [Header("Prefabs")]
        [SerializeField] private GameObject spaceship1;
        [SerializeField] private GameObject spaceship2;
        [SerializeField] private GameObject ground;
        [SerializeField] private GameObject roof;
        [SerializeField] private GameObject winPlate;
        
        private MainMenu mainMenu;
        
        
        public void Start()
        {
            Instantiate(ground);
            Instantiate(roof);
            Instantiate(winPlate);

            Instantiate(spaceship1, new Vector3(0, 1, -7), Quaternion.Euler(0, -90, 0));

            //if statement, if multiplayer = true Instantiate spaceship2 
            //if (mainMenu.multiplayer)
            //{
              //  Instantiate(spaceship2, new Vector3(0, 1, -7), Quaternion.Euler(0, -90, 0));
            //}
        }

}

