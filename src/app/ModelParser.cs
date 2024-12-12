using Newtonsoft.Json;

namespace SplineIntegration;

internal static class ModelParser
{
    internal static void ParseModel(string modelPath)
    {
        Console.WriteLine($"Parsing model at {modelPath}");

        try
        {
            // Read the glTF model from the file path
            string json = File.ReadAllText(modelPath);

            // Deserialize the JSON into a GlTF object
            RootModel? gltfModel = JsonConvert.DeserializeObject<RootModel>(json);

            if (gltfModel == null)
            {
                throw new InvalidOperationException("Failed to deserialize the model.");
            }

            // Handle the parsed data (for example, print some information about the model)
            Console.WriteLine($"Parsed glTF model: {gltfModel.asset}");
            Console.WriteLine($"Number of nodes: {gltfModel.nodes?.Count}");
            Console.WriteLine($"Number of meshes: {gltfModel.meshes?.Count}");

            // Process nodes and meshes further as needed
            foreach (var mesh in gltfModel.meshes)
            {
                Console.WriteLine($"Mesh: {mesh.name}, Primitives: {mesh.primitives?.Count}");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing the model: {ex.Message}");
        }
    }
}
