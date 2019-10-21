using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candelPickup : MonoBehaviour
{
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
        
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            if (this.gameObject.CompareTag("candel"))
            {
                player.giveCandel();
            }
            else if (this.gameObject.CompareTag("spring"))
            {
                player.giveSpring();
            }
            else if (this.gameObject.CompareTag("shoes"))
            {
                player.giveBoots();
            }
        }
        Destroy(this.gameObject);
    }
}
