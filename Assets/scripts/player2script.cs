using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contrôleur du joueur
/// </summary>
public class player2script : MonoBehaviour {

	/// <summary>
	/// 1 - La vitesse de déplacement
	/// </summary>
	public Rigidbody2D rb;

	public Vector2 speed = new Vector2(50, 50);

	// 2 - Stockage du mouvement
	private Vector2 movement;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		// 3 - Récupérer les informations du clavier/manette
		float inputX = Input.GetAxis ("player2hor");
		float inputY = Input.GetAxis ("player2ver");

		// 4 - Calcul du mouvement
		movement = new Vector2 (
			speed.x * inputX,
			speed.y * inputY);
	}


	void FixedUpdate()
	{
		// 5 - Déplacement
		rb.velocity = movement;
	}
}
