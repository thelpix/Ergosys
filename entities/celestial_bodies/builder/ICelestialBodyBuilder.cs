//interface for the builder pattern to generate celestial bodies. 
public interface ICelestialBodyBuilder
{
    //Parts
    void BuildCelestialBodyType(int seed);
    void BuildIdentifiers();
    void BuildOrbit();
    void BuildPhysicalProperties();
    void BuildResources();
    void BuildChildren();
    void BuildColony();
}