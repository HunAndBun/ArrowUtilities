using System;
using UnityEngine;

namespace ArrowUtilities.Serialization
{
    
    /// <summary>
    /// <para>Simpler Vector2 class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector2Serializable
    {
        public float x { get; set; }
        public float y { get; set; }

        #region Constructors

        public Vector2Serializable(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
            
            public Vector2Serializable(Vector2 vector2)
            {
                this.x = vector2.x;
                this.y = vector2.y;
            }
            
            public Vector2Serializable(Vector3 vector3)
            {
                this.x = vector3.x;
                this.y = vector3.y;
            }
        #endregion

        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector2</returns>
        public Vector2 ToVector2()
        {
            return new Vector2(x, y);
        }
    }
    /// <summary>
    /// <para>Simpler Vector2Int class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector2IntSerializable
    {
        public int x { get; set; }
        public int y { get; set; }

        #region Constructors

        public Vector2IntSerializable(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
            
        public Vector2IntSerializable(Vector2Int vector2Int)
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
        }
            
        public Vector2IntSerializable(Vector3Int vector3Int)
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
        }
        #endregion
        
        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector2Int</returns>
        public Vector2Int ToVector2Int()
        {
            return new Vector2Int(x, y);
        }
    }
    /// <summary>
    /// <para>Simpler Vector3 class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector3Serializable
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        #region Constructors

        public Vector3Serializable(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            
            public Vector3Serializable(Vector3 vector3)
            {
                this.x = vector3.x;
                this.y = vector3.y;
                this.z = vector3.z;
            }    
            
            public Vector3Serializable(Vector2 vector2)
            {
                this.x = vector2.x;
                this.y = vector2.y;
                this.z = 0;
            }
            

        #endregion

        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector3</returns>
        public Vector3 ToVector3()
        {
            return new Vector3(x, y, z);
        }
    }
    /// <summary>
    /// <para>Simpler Vector3Int class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector3IntSerializable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        #region Constructors
        
        public Vector3IntSerializable(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
            
        public Vector3IntSerializable(Vector3Int vector3Int)
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
            this.z = vector3Int.z;
        }
            
        public Vector3IntSerializable(Vector2Int vector2Int)
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
            this.z = 0;
        }
        #endregion
        
        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector3Int</returns>
        public Vector3Int ToVector3Int()
        {
            return new Vector3Int(x, y, z);
        }
    }
}