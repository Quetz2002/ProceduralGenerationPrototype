using UnityEngine;

public class ShapeGenerator 
{
   ShapeSettings shapeSettings;

    public ShapeGenerator(ShapeSettings settings)
    {
        this.shapeSettings = settings;
    }

    public Vector3 CalculatePointOnPlanet(Vector3 pointOnUnitSphere)
    {
        return pointOnUnitSphere * shapeSettings.planetRadius;
    }
}
