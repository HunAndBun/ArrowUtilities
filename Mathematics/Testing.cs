using ArrowUtilities.TilemapTools;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace ArrowUtilities.Mathematics
{
    public class Testing
    {
        private readonly List<int> _ints = new List<int>() {1, 2, 3, 4, 5};

        public void RandomListFunctionsTest()
        {
            //Usage of the GetReferenceToRandom method...
            var intsRandomized0 = _ints.OrderBy(_ => RNG.GetReferenceToRandom().Next()).ToList();
            //RandomizedEnumerable returning an IEnumerable...
            var intsRandomized1 = _ints.RandomizeEnumerable();
            //RandomizedEnumerable returning an IEnumerable and setting it in a list...
            var intsRandomized2 = _ints.RandomizeEnumerable().ToList();
            //RandomizedList returning a List...
            var intsRandomized3 = _ints.RandomizeList();
            //GetRandomEntry returning a single entry...
            var randomEntry = _ints.GetRandomEntry();
        }

        
        
        public void RandomFunctionsTest()
        {
            //10% chance of loot being dropped...
            if (RNG.Chance(0.1f))
            {
                //Drop some loot
            }
            
            //50% chance of enemies spawning...
            if (RNG.FiftyFifty())
            {
                //spawn some baddies
            }
            
            //Roll a D6 for initiative
            if (RNG.DiceRoll(6) > 4)
            {
                //Congrats you go first
            }
            
            //Roll a bunch of dice...
            var allTheDice = RNG.D4() + RNG.D6() + RNG.D10() + RNG.D12() + RNG.D20();
            //Fun fact: The lowest possible result is 5 while the highest is 52
        }

        public void SetSomeFancyTiles()
        {
            var tilemap = new Tilemap();
            var tile = ScriptableObject.CreateInstance<Tile>();
            var positionWithinTilemap = new Vector3Int(6, 9, 0);
            
            //Let's draw a massive square of tiles!
            tilemap.SetSquareOfTiles(positionWithinTilemap, 180, tile);
            
            //Not oblong enough... 
            tilemap.SetRectangleOfTiles(positionWithinTilemap, 90, 180, tile);
            
            //Much better!
            //How about a dotted-line?
            var position = new Vector3Int();
            for (int i = 0; i < 100; i++)
            {
                position.x = i*5;
                //These methods cache the most recently used size and tile, saving on the constant creation of
                //new TileBase[] and new Vector3Int! When finished setting tiles entirely, this array cache can be
                //cleared using TileHelperFunctions.ClearTileHelperCache();
                tilemap.SetSquareOfTiles(position, 2, tile);
            }
        }


    }
}