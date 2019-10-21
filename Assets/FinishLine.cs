using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinishLine : MonoBehaviour
{
    [SerializeField] public TextMesh scoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            player.winGame();
        }
    }
}
