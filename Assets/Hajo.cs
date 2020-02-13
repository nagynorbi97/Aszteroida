using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Hajo : MonoBehaviour {
	public GameObject kisAszteroida;
	public GameObject nagyAszteroida;
	public int kisAszteroidaSzama = 10;
	public int nagyAszteroidaSzama = 10;
    public float speed = 10f;
    void Start() {
        var kisAszteroidak = new List<GameObject>();
        for (int i = 0; i < kisAszteroidaSzama; i++) {
            int x = UnityEngine.Random.Range(-5, 5);
            int y = UnityEngine.Random.Range(-5, 5);
			var obj = Instantiate(kisAszteroida, new Vector2(x, y), Quaternion.identity);
			GameObject kisA = obj.GetComponent<GameObject>();
        }
        for (int i = 0; i < nagyAszteroidaSzama; i++) {
            int x = UnityEngine.Random.Range(-5, 5);
            int y = UnityEngine.Random.Range(-5, 5);
            var obj = Instantiate(nagyAszteroida, new Vector2(x, y), Quaternion.identity);
            GameObject kisA = obj.GetComponent<GameObject>();
        }
    }
    void FixedUpdate() {
        Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical")!=0) {
            rigidbody.transform.up = rigidbody.velocity;
        }
    }
}
