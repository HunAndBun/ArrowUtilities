// using ArrowUtilities.TilemapTools;
// using System.Collections.Generic;
// using System.Linq;
// using ArrowUtilities.Editor;
// using ArrowUtilities.Serialization;
// using UnityEngine;
// using UnityEngine.Tilemaps;
//
// namespace ArrowUtilities.Mathematics
// {
//     public class Testing
//     {
//         private readonly List<int> _ints = new List<int>() {1, 2, 3, 4, 5};
//
//         [SerializeField] [SafeRevealProperty] private int myInt = 0; //Shows in inspector without allowing editing
//         public void Demonstration()
//         {
//             //For enumerable...
//             var myList = new List<string>() { "hello", "world", "arrow", "utilities" }; //SETUP
//             var myRandomizedList = myList.Randomize().ToList(); //Randomize IEnumerable with ease!
//             var myRandomEntry = myList.GetRandomEntry(); //Retrieve one random element!
//             //For JSON serialization...
//             var myVector = new Vector3(5f, 10f, 20f);  //SETUP
//             var mySerializable = myVector.ToSerializable(); //All vector structs can be made serializable!
//             var myVectorAgain = mySerializable.ToVector3(); //And easily be turned back!
//             //For RNG...
//             var my30PercentChance = RNG.Chance(0.3f);
//             var my50PercentChance = RNG.FiftyFifty();
//             var my52SidedDie = RNG.DiceRoll(52);
//             var myOther52SidedDie = RNG.D4() + RNG.D6() + RNG.D10() + RNG.D12() + RNG.D20();
//             //For Tilemaps...
//             var myTilemap = new Tilemap();                          //SETUP
//             var myTile = ScriptableObject.CreateInstance<Tile>();   //SETUP
//             var myPosition = new Vector3Int(0, 0, 0);          //SETUP
//             myTilemap.SetSquareOfTiles(myPosition, 10, myTile); //Draws a 10x10 square of tiles
//             myTilemap.SetRectangleOfTiles(myPosition, 5, 20, myTile); //Draws a 5x20 rectangle of tiles
//             TileHelperFunctions.ClearTileHelperCache(); //Gets rid of cached values + references that speed up methods.
//         }
//         
//         
//         public void RandomListFunctionsTest()
//         {
//             //Usage of the GetReferenceToRandom method...
//             var intsRandomized0 = _ints.OrderBy(_ => RNG.GetReferenceToRandom().Next()).ToList();
//             //RandomizedEnumerable returning an IEnumerable...
//             var intsRandomized1 = _ints.Randomize();
//             //GetRandomEntry returning a single entry...
//             var randomEntry = _ints.GetRandomEntry();
//             
//         }
//
//         
//         
//         public void RandomFunctionsTest()
//         {
//             //10% chance of loot being dropped...
//             if (RNG.Chance(0.1f))
//             {
//                 //Drop some loot
//             }
//             
//             //50% chance of enemies spawning...
//             if (RNG.FiftyFifty())
//             {
//                 //spawn some baddies
//             }
//             
//             //Roll a D6 for initiative
//             if (RNG.DiceRoll(6) > 4)
//             {
//                 //Congrats you go first
//             }
//             
//             //Roll a bunch of dice...
//             var allTheDice = RNG.D4() + RNG.D6() + RNG.D10() + RNG.D12() + RNG.D20();
//             //Fun fact: The lowest possible result is 5 while the highest is 52
//         }
//
//         public void SetSomeFancyTiles()
//         {
//             var tilemap = new Tilemap();
//             var tile = ScriptableObject.CreateInstance<Tile>();
//             var positionWithinTilemap = new Vector3Int(6, 9, 0);
//             
//             //Let's draw a massive square of tiles!
//             tilemap.SetSquareOfTiles(positionWithinTilemap, 180, tile);
//             
//             //Not oblong enough... 
//             tilemap.SetRectangleOfTiles(positionWithinTilemap, 90, 180, tile);
//             
//             //Much better!
//             //How about a dotted-line?
//             var position = new Vector3Int();
//             for (int i = 0; i < 100; i++)
//             {
//                 position.x = i*5;
//                 //These methods cache the most recently used size and tile, saving on the constant creation of
//                 //new TileBase[] and new Vector3Int! When finished setting tiles entirely, this array cache can be
//                 //cleared using TileHelperFunctions.ClearTileHelperCache();
//                 tilemap.SetSquareOfTiles(position, 2, tile);
//             }
//         }
//
//         public void DoSomeConversions()
//         {
//             var vec2 = new Vector3Int(0,0);
//             var serializable = vec2.ToSerializable();
//             var vecRetrieved = serializable.ToVector3Int();
//         }
//
//     }
// }