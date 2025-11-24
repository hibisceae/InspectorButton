using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace InspectorButton
{
    [CustomEditor(typeof(MonoBehaviour), true), CanEditMultipleObjects]
    public class InspectorButtonEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            MonoBehaviour monoBehavior = (MonoBehaviour)target;

            Type type = monoBehavior.GetType();

            foreach (
                MethodInfo method in type.GetMethods(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                )
            )
            {
                if (!Attribute.IsDefined(method, typeof(InspectorButtonAttribute)))
                    continue;

                var attributes = Attribute.GetCustomAttributes(
                    method,
                    typeof(InspectorButtonAttribute)
                );

                foreach (InspectorButtonAttribute attribute in attributes)
                {
                    if (GUILayout.Button(attribute.Name))
                    {
                        if (!Application.isPlaying)
                            continue;

                        method.Invoke(monoBehavior, attribute.Params);
                    }
                }
            }
        }
    }
}
