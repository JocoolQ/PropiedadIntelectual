using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabricaEsferas : MonoBehaviour {
	public Material mat1;
	public Material mat2;
	public float escalaEsferas;
	public GameObject padre;
	public PhysicMaterial matP;
	public int esferasPorFrame;
	public int intervaloFrame;
	public int frame;
	int num;
	// Use this for initialization
	void Start () {
		frame = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (frame % intervaloFrame == 0) {
			for (int i = 0; i < esferasPorFrame; i++) {
				GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				sphere.name = "particula";
				sphere.transform.SetParent(padre.transform);
				sphere.GetComponent<SphereCollider> ().material = matP;
				sphere.AddComponent<Rigidbody>();
				num = Random.Range(0,2);
				if (num == 1) {
					sphere.GetComponent<MeshRenderer> ().material = mat1;
					//print ("1");
				} else {
					sphere.GetComponent<MeshRenderer>().material = mat2;
					//print ("2" + "  " + num);
				}
				sphere.transform.localScale = new Vector3(escalaEsferas,escalaEsferas,escalaEsferas);
				sphere.transform.position = gameObject.transform.position;
			}
		}
		frame++;
	}

}
