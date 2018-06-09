using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour {

	public Sprite[] sprites;
	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer>();
		sr.sprite = sprites[Random.Range(0,sprites.Length)];

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
