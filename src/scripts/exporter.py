import bpy
import os

# Set the file path to export as *.gltf in the same directory as the blend file
script_directory = os.path.dirname(bpy.data.filepath)
export_path = os.path.join(script_directory, "exported_model.gltf")

# Set to object mode
bpy.ops.object.mode_set(mode='OBJECT')

# Select all objects in the scene for export
bpy.ops.object.select_all(action='SELECT')

# Export the selected objects to the specified file path
bpy.ops.export_scene.gltf(
    filepath=export_path,
    export_format='GLTF_SEPARATE',
    use_selection=False,
    export_texcoords=True,
    export_materials='EXPORT',
)

print(f"Exported all objects with materials and textures to {export_path}")