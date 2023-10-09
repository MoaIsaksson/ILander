using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameScript : MonoBehaviour
{
        [Header("Prefabs")]
        [SerializeField] private GameObject spaceship1;
        [SerializeField] private GameObject spaceship2;
        [SerializeField] private GameObject ground;
        [SerializeField] private GameObject roof;
        [SerializeField] private GameObject winPlate; 
        [SerializeField] private GameObject boostCube;

        private bool _multiplayer;
        
        public void Start()
        {
            Instantiate(ground);
            Instantiate(roof);
            Instantiate(winPlate);
            Instantiate(spaceship1, new Vector3(0, 1, -7), Quaternion.Euler(0, -90, 0));

            Vector3 randomposition = new Vector3(Random.Range(11, 15), Random.Range(2,3), -6);
            Instantiate(boostCube, randomposition, quaternion.identity);
            
            // if statement to instantiate the second spaceship
            if (_multiplayer)
            {
               Instantiate(spaceship2, new Vector3(0, 1, -7), Quaternion.Euler(0, -90, 0));
            }
        }
}

