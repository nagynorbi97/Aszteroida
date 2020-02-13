using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {
    public GameObject player;
    void Update() {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
