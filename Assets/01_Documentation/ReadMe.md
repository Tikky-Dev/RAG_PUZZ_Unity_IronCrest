# IronCrest
___
**Company**: Ragnarok Development

**Developer**: Gregor Stojanovic

**Type**: Puzzle game

**Code**: RAG_PUZZ_Unity_IronCrest

**Version**: 0.0.0
___

### Game Description
IronCrest is story-driven puzzle game set in a post-apocalyptic, futuristic world.
In this adventure, players controls a robot and embarks on a mission to collect Iron Crests,
essential to creating a signal for humanity's return to a desolate planet.
The core gameplay mechanics of IronCrest revolve around solving puzzles by strategically
crafting an array of movement instructions on a tile grid-based system. As you navigate levels,
labyrinths, and challenging terrains, you must collect Iron Crests while managing your battery's limited energy and limited memory.
Your journey is further complicated by conductive terrain, isolative obstacles, Faraday cages, and hazardous areas.

## Behaviours and mechanics

### Robot behaviour
 - Grid movement
 - Tile movement
 - Battery functionality
 - Limited memory functionality
 - States:
   - **automatic mode** (follows instructions predetermined by the player)
   - **manual mode** (player moves robot in real time)
   - **confused mode** (robot returns to the beginning and repeats instructions)
   - **death mode** (no battery, confused no solution, hazard damage)

Robot state flow chart (the PlantUml diagram can be found [here](./UMLDiagrams/RobotState.puml))
![Robor state diagram](./Images/DiagramImage_RobotState.png)


### Environment behaviour
- **Tile grid**
- **Conductive tiles** (infinite battery)
- **Isolation tiles** (Limited battery)
- **Faraday Cage** (goes into automatic mode)
- **Hazard tiles/environment** (Kills robot)

### Maps, levels & Terrains
- Factory - The starting point of the game
- City
- Forest
- Forge - The end point of the game

Over all map design (the PlantUml diagram can be found [here](./UMLDiagrams/))
![Map design diagram](./Images/DiagramImage_OverAllMapDesign.png)