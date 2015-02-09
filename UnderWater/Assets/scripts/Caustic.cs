using UnityEngine;
using System.Collections;

public class Caustic : MonoBehaviour {
	public Texture2D[] frames;
	public float fps=30f;
	public Transform obj;
	private int frameInd;
	private Projector projector;
	private Vector3 temp=Vector3.zero;
	// Use this for initialization
	void Start () {
		projector = GetComponent<Projector> ();
		NextFrame ();
		InvokeRepeating ("NextFrame", 1 / fps, 1 / fps);
	}
	
	// Update is called once per frame
	void NextFrame () {

		projector.material.SetTexture("_ShadowTex",frames[frameInd]);
		frameInd = (frameInd + 1) % frames.Length;
	}
	void Update(){
		temp = new Vector3 (obj.transform.position.x, obj.transform.position.y+5f, obj.transform.position.z);
		transform.position=new Vector3(temp.x, temp.y, temp.z);
	}
}
