namespace SplineIntegration;

internal class Program
{
    static void Main(string[] args)
    {
        ModelParser.ParseModel("C:\\BlenderSplineTranslator\\Sample Blender Files\\exported_model.gltf");
        Console.WriteLine("Press any key to close the program....");
        Console.ReadKey();
    }
}
