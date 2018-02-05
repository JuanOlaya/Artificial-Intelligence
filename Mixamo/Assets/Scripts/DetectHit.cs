using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHit : MonoBehaviour 
{

	Animator anim;
	int hit=0;
	Animator animZombie;
	CapsuleCollider colliderGrandma;
	CapsuleCollider colliderZombie;
	bool playerIsDead=false;
	Transform locationZombie;

	void Start () 
	{
		anim = GetComponent<Animator> ();

		colliderGrandma = GetComponent<CapsuleCollider> ();

		colliderZombie = GameObject.Find("Zombie").GetComponent<CapsuleCollider> ();
		animZombie = GameObject.Find("Zombie").GetComponent<Animator> ();
		locationZombie = GameObject.Find ("Zombie").GetComponent<Transform> ();
	}
		
	void OnTriggerEnter(Collider other)
	{
		//Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Weapon") 
		{
			hit++;
			Debug.Log ("Hit" + hit);
			if (hit < 4) 
			{
				PunchReaction ();
			}
		}
	}
		
	void Update () 
	{
		if (hit == 4 && !playerIsDead) 
		{
			playerIsDead = true;
		}
	}

	void PunchReaction()
	{
		anim.SetTrigger ("PunchReaction");
	}
}