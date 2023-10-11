using UnityEngine;
using System.Collections;
using LibNoise;
using LibNoise.Generator;

public class Noise_script : MonoBehaviour 
{

	[SerializeField] int seed = 0;

	void Start()
	{
        float _left = 1;

        float _right = 5;

        float _top = 2;

        float _bottom = 6;
        
		var perlin = new Perlin(1,2,0.5,6,seed,0);

        var noiseMapBuilder = new Noise2D(256, 256, perlin);
		noiseMapBuilder.GeneratePlanar(_left, _right, _top, _bottom);

		var image = noiseMapBuilder.GetTexture(GradientPresets.Grayscale);

		GetComponent<Renderer>().material.mainTexture = image;
	}
}
