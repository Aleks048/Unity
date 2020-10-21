using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 50.0f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
       // PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null){
            Debug.Log("Player Hit");
            player.hurt(1);
            Destroy(this.gameObject);
        } else {
            Debug.Log("Not Player Hit");
            Destroy(this.gameObject);
        }
    }
}
