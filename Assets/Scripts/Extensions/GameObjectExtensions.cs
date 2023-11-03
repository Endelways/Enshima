using System;
using UnityEngine;

public static class GameObjectExtensions
{
    public static Transform FirstChildOrDefault(this Transform parent, Func<Transform, bool> query)
    {
        if (parent.childCount == 0)
        {
            return null;
        }

        Transform result = null;
        for (int i = 0; i < parent.childCount; i++)
        {
            var child = parent.GetChild(i);
            if (query(child))
            {
                return child;
            }
            result = FirstChildOrDefault(child, query);
        }

        return result;
    }

    public static Transform FindParent(this Transform child, Func<Transform, bool> query)
    {
        if (child.parent == null)
        {
            return null;
        }

        Transform parent = child.parent;
        if (query(parent))
            return parent;
        else
            return FindParent(parent, query);
    }
}

