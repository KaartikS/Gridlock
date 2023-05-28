using UnityEngine;

namespace Gridlock{
    public static class Extensions 
    {
        public static Vector3 ToVector3(this Vector2Int vector2int)
        {
            return new Vector3(vector2int.x, 0, vector2int.y);
        }
    }
}