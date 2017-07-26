using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainEvent : MonoBehaviour {
	bool excute;
	public static string[] answer = new string[7];
	public static string[] gameCup = new string[7];
	Vector3 beforePos;

	// Use this for initialization
	void Start () {
		excute = true;
	}

	// Update is called once per frame
	void Update () {
		GameObject water = GameObject.Find ("water");
		GameObject cupObj;
		GameObject allCup = GameObject.Find ("cup");
		GameObject answer1 = GameObject.Find ("answer1");
		GameObject answer2 = GameObject.Find ("answer2");
		bool correct = true;
		float newPos;
		Vector3 beforePos = allCup.transform.position;

		if (excute == true) {
			for (int i = 0; i < 4; i++) {
				if (answer [i] != gameCup [i]) {
					correct = false;
					break;
				}
			}

			if (correct) {
				for (int i = 0; i < 4; i++) {
					cupObj = GameObject.Find ("cup_" + i);

					while(!cupObj.gameObject.GetComponent<SpriteRenderer> ().sprite.name.Equals ("cup_" + answer [i]))
						water.GetComponent<Rigidbody2D> ().gravityScale = 0.5f;

					cupObj.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + answer [i]);
					newPos = beforePos.y - 2.1f;
					allCup.transform.position = new Vector3 (beforePos.x, newPos, beforePos.z);
				}
			}
			Destroy (answer1);
			answer2.transform.position = new Vector3 (-5.9f, 8.5f, 0.0f);
		}
	}
}