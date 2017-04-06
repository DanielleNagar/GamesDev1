using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffectsHelper : MonoBehaviour {

	// Use this for initialization
	public static SpecialEffectsHelper Instance;

	public ParticleSystem DeathP;
	public ParticleSystem GlitP;

	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SpecialEffectsHelper!");
		}

		Instance = this;
	}


	public void ExplosionP(Vector3 position)
	{
		




		instantiate(DeathP, position);
	}
	public void ExplosionG(Vector3 position)
	{

		instantiate(GlitP, position);



	}


	private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate(
			prefab,
			position,
			Quaternion.identity
		) as ParticleSystem;

		// Make sure it will be destroyed
		Destroy(
			newParticleSystem.gameObject,
			newParticleSystem.startLifetime
		);

		return newParticleSystem;
	}
}
