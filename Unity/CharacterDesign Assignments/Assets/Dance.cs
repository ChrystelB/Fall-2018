using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dance Moves", menuName = "Dance")]
public class Dance : ScriptableObject {

	public string danceMove;
	public string description;

	public int attack;
	public int health;

	public void Print() {
		Debug.Log(danceMove + ": " + description + " The Dance attack = " + attack);
	}
}
