# ItemPlanner
Constructor
# Architecture
Combination of modular system (decomposition) and MVC

Each scene has:
* Main controller (Controller) 
* UI Controller (View)
* Data (Model) It may not be if the scene uses only data from the global module
The main controller initializes and calls all the necessary modules that should be used on scene.

Modules

Each module can only be accessed through the interface. This does not apply to the global module and scenes.

Modules communicate with each other only through received events or requested data in initialization.
This is done to enable the replacement of modules without extra time

Each module has its own MVC-based architecture for maximum autonomy
The module may not have Model ow View if there is no need to use. For example, a game module may give game state information to the one who created it. And the creator, if desired, can visualize this information

Decomposition levels:
* 0 ItemPlanner
* 1 ItemPlanner.SceneModules (Has a scene controller that activates all the necessary modules)
* 1 ItemPlanner.GlobalModule 
* 1 ItemPlanner.ConstructorModule
* 2 ItemPlanner.ConstructorModule.ConstructorUIModule
* 2 ItemPlanner.ConstructorModule.CreatorModule
* 2 ItemPlanner.ConstructorModule.ObjectModule
* 2 ItemPlanner.ConstructorModule.WallModule
