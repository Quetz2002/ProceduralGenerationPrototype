using UnityEngine;

public class NoiseFilter
{
  NoiseSettings settings;
  Noise noise = new Noise();

  public NoiseFilter(NoiseSettings settings)
  {
    this.settings = settings;
  }

  public float Evaluate(Vector3 point)
  {
    float amplitude = 1;
    float frequency = settings.baseRoughness;
    float noiseValue = 0;
    
    for(int i = 0; i < settings.numLayers; i++)
    {
      float perlinValue = noise.Evaluate(point * frequency + settings.centre);
      noiseValue += (perlinValue + 1) * 0.5f * amplitude;
      amplitude *= settings.persistence;
      frequency *= settings.roughness;
    }
    
    noiseValue = Mathf.Max(noiseValue - settings.minValue, 0);
    return noiseValue * settings.strength;
  }
}
