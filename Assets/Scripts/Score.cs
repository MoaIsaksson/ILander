using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public GameObject Player1;
    public TextMeshProUGUI ScoreText;


    void Update() {
        
        Player1 = GameObject.FindWithTag("Player");

        ScoreText.text = Player1.transform.position.x.ToString("0");
    }
}
