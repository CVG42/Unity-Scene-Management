using System;
using UnityEngine;

namespace CVG42.SceneManagement.SceneReference
{
    [Serializable]
    public sealed class SceneReference
    {
        [SerializeField, HideInInspector] private string scenePath;

        public string Path => scenePath;

        public string LoadPath
        {
            get
            {
                if (string.IsNullOrEmpty(scenePath))
                {
                    return string.Empty;
                }

                if (scenePath.EndsWith(".unity"))
                {
                    return scenePath.Substring(0, scenePath.Length - ".unity".Length);
                }

                return scenePath;
            }
        }

        public bool IsValid => !string.IsNullOrWhiteSpace(scenePath);

        public override string ToString()
        {
            return scenePath;
        }
    }
}