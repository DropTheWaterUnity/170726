using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Instruction;
using ObjectHierachy;
using System.IO;

public class makeStage : MonoBehaviour {
	public delegate void Clear ();
	public GameObject[] cup;
	public GameObject[] answerCup;
	public GameObject[] underCup;

	public static Clear clearEvent;


	public Vector3[] waterPosition; // water drop

	// Use this for initialization
	void Start () {
		loadStage (Resource.stage);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void loadStage(int stage) {
		Debug.Log (Resource.stage);
		TextAsset data = Resources.Load ("StageText/text" + stage, typeof(TextAsset)) as TextAsset;
		StringReader str = new StringReader (data.text);


		string line;

		while((line = str.ReadLine()) != null) {
			if(line.Equals("cup")){
				line = str.ReadLine();
				string[] o = line.Split (new char[]{ ' ' });
				Debug.Log (o [0]);
				createCup (int.Parse (o [0]), int.Parse (o [1]), int.Parse (o [2]), int.Parse (o [3]), int.Parse (o [4]), int.Parse (o [5]), int.Parse (o [6]));

			}
			else if(line.Equals("answer")) {
				line = str.ReadLine();
				string[] o = line.Split (new char[]{ ' ' });
				createAnswer (int.Parse (o [0]), int.Parse (o [1]), int.Parse (o [2]), int.Parse (o [3]), int.Parse (o [4]), int.Parse (o [5]), int.Parse (o [6]));
			}
		}
	}


	public void createCup(int a, int b, int c, int d, int e, int f, int g){
		cup [0].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + a);
		cup [1].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + b);
		cup [2].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + c);
		cup [3].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + d);
		cup [4].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + e);
		cup [5].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + f);
		cup [6].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + g);

		mainEvent.gameCup [0] = a.ToString ();
		mainEvent.gameCup [1] = b.ToString ();
		mainEvent.gameCup [2] = c.ToString ();
		mainEvent.gameCup [3] = d.ToString ();
		mainEvent.gameCup [4] = e.ToString ();
		mainEvent.gameCup [5] = f.ToString ();
		mainEvent.gameCup [6] = g.ToString ();

	}

		
	public void createAnswer(int a, int b, int c, int d, int e, int f, int g){
		answerCup[0].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + a);
		answerCup[1].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + b);
		answerCup[2].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + c);
		answerCup[3].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + d);
		answerCup[4].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + e);
		answerCup[5].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + f);
		answerCup[6].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + g);

		underCup[0].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + a);
		underCup[1].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + b);
		underCup[2].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + c);
		underCup[3].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + d);
		underCup[4].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + e);
		underCup[5].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + f);
		underCup[6].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + g);

		mainEvent.answer [0] = a.ToString ();
		mainEvent.answer [1] = b.ToString ();
		mainEvent.answer [2] = c.ToString ();
		mainEvent.answer [3] = d.ToString ();
		mainEvent.answer [4] = e.ToString ();
		mainEvent.answer [5] = f.ToString ();
		mainEvent.answer [6] = g.ToString ();
	}

	
}