using UnityEditor;
using UnityEngine;

namespace CVG42.SceneManagement.SceneReference.Editor
{
    [CustomPropertyDrawer(typeof(SceneReference))]
    public sealed class SceneReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty scenePathProperty = property.FindPropertyRelative("scenePath");

            SceneAsset currentScene = null;

            if (!string.IsNullOrEmpty(scenePathProperty.stringValue))
            {
                currentScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(scenePathProperty.stringValue);
            }

            EditorGUI.BeginProperty(position, label, property);

            SceneAsset selectedScene = EditorGUI.ObjectField(position, label, currentScene, typeof(SceneAsset), false) as SceneAsset;

            if (selectedScene != currentScene)
            {
                scenePathProperty.stringValue = selectedScene != null ? AssetDatabase.GetAssetPath(selectedScene) : string.Empty;
            }

            EditorGUI.EndProperty();
        }
    }
}