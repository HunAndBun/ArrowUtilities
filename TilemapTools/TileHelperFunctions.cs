using ArrowUtilities.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace ArrowUtilities.TilemapTools
{
    /// <summary>
    /// <para>Static class containing methods designed to set many tiles at runtime in a performant way.</para>
    /// </summary>
    public static class TileHelperFunctions
    {

        private static int _size, _height, _width;
        private static Tile _tileForSquare, _tileForRectangle;
        private static Vector3Int _sizeForSquare, _sizeForRectangle;
        private static TileBase[] _tilesForSquare, _tilesForRectangle;

        /// <summary>
        /// <para>Helper method for setting a square of tiles all at once.
        /// <br/><b>Note: This statically caches the values for size and tile, so continuous usage (with the same parameters) remains performant.</b></para>
        /// </summary>
        /// <param name="tilemap">The Tilemap asset to set to.</param>
        /// <param name="bottomLeftCorner">The bottom, leftmost corner of the shape.</param>
        /// <param name="size">The number of tiles per side.</param>
        /// <param name="tile">The tile to set.</param>
        public static void SetSquareOfTiles(this Tilemap tilemap, Vector3Int bottomLeftCorner, int size, Tile tile)
        {
            BoundsInt boundsInt;
            if (size == _size) //If the size chosen is the same as the previous usage...
            {
                boundsInt = new BoundsInt(bottomLeftCorner, _sizeForSquare); //Reuse the size Vector3Int.
                if (tile == _tileForSquare) //If the tile is the same too...
                {
                    tilemap.SetTilesBlock(boundsInt, _tilesForSquare); //Reuse both (max performance) and do the final set.
                    return;
                }
            }
            else //If the size is altered from the previous usage...
            {
                _sizeForSquare = new Vector3Int(size, size, 1); //Set and cache the new size.
                boundsInt = new BoundsInt(bottomLeftCorner, _sizeForSquare); //Setup the new bounds.
                _size = size; //Cache the size integer
            }
            _tilesForSquare = EnumerableHelpers.GetPreFilledArray<TileBase> //Get an array filled with the same tile, and cache it too.
            (
                boundsInt.size.x * boundsInt.size.y * boundsInt.size.z, //Tilemaps are technically 3D (sorta) so you need the same number of tiles as a "cube" of them would entail.
                tile
            );
            _tileForSquare = tile; //Cache the tile.

            tilemap.SetTilesBlock(boundsInt, _tilesForSquare); //Do the final set.
        }
        
        /// <summary>
        /// <para>Helper method for setting a rectangle of tiles all at once.
        /// <br/><b>Note: This statically caches the values for size and tile, so continuous usage (with the same parameters) remains performant.</b></para>
        /// </summary>
        /// <param name="tilemap">The Tilemap asset to set to.</param>
        /// <param name="bottomLeftCorner">The bottom, leftmost corner of the shape</param>
        /// <param name="height">The number of tiles on the y axis</param>
        /// <param name="width">The number of tiles on the x axis</param>
        /// <param name="tile">The tile to set.</param>
        public static void SetRectangleOfTiles(this Tilemap tilemap, Vector3Int bottomLeftCorner, int height, int width, Tile tile)
        {
            BoundsInt boundsInt;
            if (height == _height && width == _width) //If the size chosen is the same as the previous usage...
            {
                boundsInt = new BoundsInt(bottomLeftCorner, _sizeForRectangle); //Reuse the size Vector3Int.
                if (tile == _tileForRectangle) //If the tile is the same too...
                {
                    tilemap.SetTilesBlock(boundsInt, _tilesForRectangle); //Reuse both (max performance) and do the final set.
                    return;
                }
            }
            else
            {
                _sizeForRectangle = new Vector3Int(width, height, 1); //Set and cache the new size
                boundsInt = new BoundsInt(bottomLeftCorner, _sizeForRectangle); //Set up the new bounds
                _width = width; //Cache the size integers.
                _height = height;
            }
            _tilesForRectangle = EnumerableHelpers.GetPreFilledArray<TileBase> //Get array filled with the same tile, and cache it too.
            (
                boundsInt.size.x * boundsInt.size.y * boundsInt.size.z, //Tilemaps are technically 3D (sorta) so you need the same number of tiles as a "rectangular prism" of them would entail.
                tile
            );
            _tileForRectangle = tile; //Cache the tile.

            tilemap.SetTilesBlock(boundsInt, _tilesForRectangle); //Do the final set.
        }

        /// <summary>
        /// <para>Nullifies the cached data for the SetSquareOfTiles and SetRectangleOfTiles methods. <br/>
        /// Use this when either method is no longer being utilized in the scene, and likely will not be used again.</para>
        /// </summary>
        public static void ClearTileHelperCache()
        {
            //Set everything to zero or null. The only actual memory savings are with the now-null types,
            //but setting everything to zero will ensure the next usage of the setter methods starts fresh.
            _tileForRectangle = null;
            _tileForSquare = null;
            _tilesForSquare = null;
            _tilesForRectangle = null;
            _size = 0;
            _height = 0;
            _width = 0;
            _sizeForRectangle = Vector3Int.zero;
            _sizeForSquare = Vector3Int.zero;
        }
        
    }
}