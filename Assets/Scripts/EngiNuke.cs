﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EngiNuke : PlayerAbility {

	public int Damage;
	public int BlastRange;

	private List<Enemy> mEnemyTargets;
	

	public override void UseAbility (Vector3 targetLoc, int modify, GameController controller)
	{

		Instantiate (Particles, targetLoc, Quaternion.identity);

		for (int i = 0; i < controller.Enemies.Count; i++) {

			mEnemyTargets.Add (controller.Enemies[i]);

				}


		for (int j=0; j < mEnemyTargets.Count; j++) {

			if (Vector3.Distance (mEnemyTargets[j].transform.position, targetLoc) <= BlastRange){
			
			mEnemyTargets[j].TakeDamage(Damage);
			}

				}

		mEnemyTargets.Clear ();

	}
		
}
