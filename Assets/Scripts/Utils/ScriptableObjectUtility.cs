using UnityEngine;
using UnityEditor;

using System.IO;

namespace Heroes.EditorUtils
{
    public static class ScriptableObjectUtility
    {
        public static void CreateAsset<T>(string path) where T : ScriptableObject
        {
            T asset = ScriptableObject.CreateInstance<T>();

            if (string.IsNullOrEmpty(path))
            {
                if(Selection.activeObject != null)
                {
                    path = AssetDatabase.GetAssetPath(Selection.activeObject);
                }

                if (string.IsNullOrEmpty(path))
                {
                    path = "Assets/New" + typeof(T).ToString();
                }
            }

            path = path.Replace(Application.dataPath, "Assets");

            string extension = Path.GetExtension(path);
            if (!string.IsNullOrEmpty(extension))
            {
                path = path.Replace(extension, "");
            }

            string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + ".asset");

            AssetDatabase.CreateAsset(asset, assetPathAndName);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        /// <summary>
        //	This makes it easy to create, name and place unique new ScriptableObject asset files.
        /// </summary>
        public static void CreateAsset<T>() where T : ScriptableObject
        {
            string path = EditorUtility.SaveFilePanel("Save asset", "", typeof(T).ToString(), "asset");

            CreateAsset<T>(path);
        }
    }
}