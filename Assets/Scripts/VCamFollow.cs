using Cinemachine;
using UnityEngine;

public class VCamFollow : MonoBehaviour
{
    private CinemachineVirtualCamera _vCam;
   
   [SerializeField] private GameObject player1;

    private Transform FollowTarget { get; set; }

    public void Start() {
        
        _vCam = GetComponent<CinemachineVirtualCamera>();
        
    }

    private void Update()
    {
        if (player1 == null) {
            
            player1 = GameObject.FindGameObjectWithTag("Player");
        }
        
        if (player1 != null) {
            
            FollowTarget = player1.transform;
            _vCam.LookAt = FollowTarget;
            _vCam.Follow = FollowTarget;
        }
    }
}
