namespace WyattSandersPortfolio.Models.PortfolioData
{
    public struct TextOnlyProjectData { 
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }

    public struct ImgProjectData
    {
        public string DisplayName { get; set; }
        public string DisplayImg { get; set; }
        public string Caption { get; set; }
    }
    public class ProjectData
    {

        public static readonly Dictionary<string, List<Skill>> projectsToSkills = new Dictionary<string, List<Skill>>
        {
            { "3WayMerge", new List<Skill> { Skill.Java, Skill.DebuggingCode, Skill.SoftwareTesting, Skill.Algorithms, Skill.AsymtoticNotation, Skill.DataStructures, Skill.DataAnalysis } },
            { "SpaceWar", new List<Skill> { Skill.CSharp, Skill.DebuggingCode, Skill.GameDevelopment, Skill.SoftwareTesting, Skill.Algorithms, Skill.AsymtoticNotation, Skill.DataStructures, Skill.NetworkEngineering, Skill.Json, Skill.XML, Skill.dotNetFramework } },
            { "NetworkedSpreadsheet", new List<Skill> { Skill.CSharp, Skill.DebuggingCode, Skill.SoftwareTesting, Skill.Algorithms, Skill.DataStructures, Skill.NetworkEngineering, Skill.Json, Skill.CollabrativeProblemSolving, Skill.Communication, Skill.Teamwork, Skill.ProjectPlanning, Skill.C, Skill.MySQL, Skill.dotNetFramework } },
            { "ExploringCallStack", new List<Skill> { Skill.MIPS, Skill.DebuggingCode, Skill.DataStructures } },
            { "AlgorithExplorationMajorityVote", new List<Skill> { Skill.CSharp, Skill.DebuggingCode, Skill.Algorithms, Skill.AsymtoticNotation } },
            { "ChessDatabase", new List<Skill> { Skill.MySQL, Skill.DataAnalysis, Skill.CSharp, Skill.LINQ, Skill.DebuggingCode, Skill.Algorithms, Skill.AsymtoticNotation, Skill.dotNetFramework } },
            { "PeerToPeerNetworking", new List<Skill> { Skill.NetworkEngineering, Skill.Python, Skill.DataStructures, Skill.Algorithms } },
            { "RandomForestDecisionTrees", new List<Skill> { Skill.Python, Skill.DataStructures, Skill.Algorithms, Skill.DataAnalysis } },
            { "ModelsOfComputation", new List<Skill> { Skill.Python, Skill.DataStructures, Skill.Algorithms, Skill.Communication } },
            { "LowLevelOptimization", new List<Skill> { Skill.C, Skill.Algorithms, Skill.DataStructures, Skill.DebuggingCode } },
            { "AlphaBetaPruning", new List<Skill> { Skill.Python, Skill.DataStructures, Skill.Algorithms, Skill.Teamwork, Skill.CasualGames, Skill.GameDevelopment } },
            { "HackTheU", new List<Skill> { Skill.React, Skill.ProblemSolving, Skill.Teamwork, Skill.Algorithms, Skill.Leadership, Skill.GameDevelopment } },
            { "WestonScienceScholars", new List<Skill> { Skill.Teamwork, Skill.DataStructures, Skill.ProblemSolving, Skill.FullStackDevelopment } },
            { "VideogameAnalysis", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign } },
            { "GameExecutionFlowchart", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign } },
            { "FalterGame", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign } },
            { "CharacterConcepting", new List<Skill> { Skill.GameDevelopment } },
            { "Pawtection", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign, Skill.Lua, Skill.XML, Skill.CasualGames, Skill.Teamwork, Skill.ProjectPlanning } },
            { "TurnCloakGame", new List<Skill> { Skill.GameDevelopment, Skill.GameDesign, Skill.Cplusplus, Skill.Teamwork } },
            { "SnowyDiorama", new List<Skill> { Skill.GameDevelopment, Skill.Cplusplus } },
            { "SingularityTurnTracker", new List<Skill> { Skill.Lua, Skill.Modding, Skill.XML } },
            { "AmoebasAndMore", new List<Skill> { Skill.Modding, Skill.SoftwareTesting, Skill.GameDesign, Skill.DataStructures, Skill.Communication, Skill.Teamwork } },
            { "GameCraft", new List<Skill> { Skill.GameDesign, Skill.GameDevelopment, Skill.Communication, Skill.CSharp, Skill.Unity } },
            { "IDTech", new List<Skill> { Skill.Modding, Skill.SoftwareTesting, Skill.GameDesign, Skill.GameDevelopment, Skill.Java, Skill.dotNetFramework } },
            { "MarbleDrop", new List<Skill> { Skill.GameDevelopment, Skill.CasualGames } }
        };


        public static readonly Dictionary<string, ImgProjectData> ImgProjectsToDescriptions = new Dictionary<string, ImgProjectData>
        {
            { "SnowyDiorama", new ImgProjectData{DisplayName = "Snowy Diorama",DisplayImg = "Images/GamesProjects/SnowyDiorama01.gif" , Caption="Created a stylized snow diorama using Unreal 5, demonstrating hands-on skills in 3D modeling, texturing, and Niagara particle systems." } },
            { "Pawtection", new ImgProjectData{DisplayName = "Pawtection",DisplayImg = "Images/GamesProjects/pawtectionGameBoard.png" , Caption="Jigsaw your way through a heart-wrenching puzzle game of limited space and moral dilemmas in this competitive puzzle game." } },
            { "VideogameAnalysis", new ImgProjectData{DisplayName = "Game Controller Diagram",DisplayImg = "Images/GamesProjects/GamesControlMap.png" , Caption="Designed an intuitive game control diagram, mapping each in-game function to corresponding buttons on a controller." } },
            { "GameExecutionFlowchart", new ImgProjectData{DisplayName = "Game Execution Flowchart",DisplayImg = "Images/GamesProjects/GameExecutionFlowChart.png" , Caption="Constructed a game execution flowchart as a design blueprint, delineating hierarchy and order of in-game systems." } },
            { "SpaceWar", new ImgProjectData{DisplayName = "Space War",DisplayImg = "Images/CSProjects/SpaceWar.png" , Caption="Blast into action and compete against friends and AI to dominate the system. Adapt your battles across the stars with flexible server settings." } },
            { "FalterGame", new ImgProjectData{DisplayName = "Falter",DisplayImg = "Images/GamesProjects/FalterBanner.png" , Caption="Embark on a dark quest for justice and grow to master the blade in \"Falter,\" a gripping game set against the backdrop of invasion." } },
            { "CharacterConcepting", new ImgProjectData{DisplayName = "Character Concepting",DisplayImg = "Images/GamesProjects/CharacterConcept.png" , Caption="An adorable dueling robot designed for a cute Metroidvania, bringing charm and classy excitement." } },
            { "TurnCloakGame", new ImgProjectData{DisplayName = "Turn Cloak",DisplayImg = "Images/GamesProjects/TurnCloak.png" , Caption="Embark on an espionage mission in a snowy industrial complex, infiltrating the secret enemy base, acquiring crucial plans, and executing a daring escape." } },
            { "AmoebasAndMore", new ImgProjectData{DisplayName = "Amoebas And More",DisplayImg = "Images/GamesProjects/AmoebasAndMore.jpg" , Caption="Hunt your enemies with an army of space faring Amoeba bred for war by your top scientists in this mod for Stellaris."} },
            { "MarbleDrop", new ImgProjectData{DisplayName = "Marble Drop",DisplayImg = "Images/GamesProjects/MarbleDrop.png" , Caption="Simple yet addicting marble drop game. Keep the marble alive by skillfully maneuvering left and right, finding the gaps in ascending platforms." } }
        };
        public static readonly Dictionary<string, TextOnlyProjectData> textProjectsToDescriptions = new Dictionary<string, TextOnlyProjectData>
        {
            { "3WayMerge", new TextOnlyProjectData{DisplayName = "3-Way Merge", Description="Delved into sorting algorithms by creating two nonrecursive merge-sort versions and assessing their mean efficiency across numerous isolated tests. Applied the traditional technique of merging two sorted lists, alongside a unique method of merging three lists concurrently." } },
            { "SpaceWar", new TextOnlyProjectData{DisplayName = "Space Wars", Description= "Applied a model-view controller design pattern through pair programming to recreate Space Wars, a multiplayer networked game that flexibly configures its server using XML. Through this project, I gained hands-on experience in networking, sockets, Tcp, and the effective use of delegates."} },
            { "NetworkedSpreadsheet", new TextOnlyProjectData{DisplayName = "Networked Spreadsheet", Description=  "Refactored old code with a team of 4 to upgrade an existing spreadsheet with network functionality. Engineered a multi-threaded server in C++ and SQLite, negotiated a network communication protocol and implemented a dependency graph on the server side.  Created automated tests for project polish and support for saving to a CSV format."} },
            { "ExploringCallStack", new TextOnlyProjectData{DisplayName = "Exploring Call Stack", Description= "Explored the complexities of the call stack's low-level operations by reconstructing it in Mips assembly. Utilized the project to trace the stack pointer during recursion and method returns." } },
            { "AlgorithExplorationMajorityVote", new TextOnlyProjectData{ DisplayName = "Majority Vote", Description= "Took on the implementation of the Majority Vote algorithm, participating in a friendly competition with peers to optimize runtime. Working on this project gave me a new appreciation of algorithms, efficient computation and resource utilization." } },
            { "ChessDatabase", new TextOnlyProjectData{ DisplayName = "Chess Database", Description= "Engineered a chess data parsing solution, consolidating information into a well-organized relational database structure, and implemented a user-friendly interface with versatile Linq queries to enhance the user experience and enable efficient data exploration." } },
            { "PeerToPeerNetworking", new TextOnlyProjectData{ DisplayName = "P2P Networking", Description= "Enhanced my understanding of networking principles with a hands-on project, creating a P2P filesharing system. This involved independently formulating a networking protocol and constructing server and client applications to facilitate file exchange, including support for exchanging multiple files across a single connection."} },
            { "RandomForestDecisionTrees", new TextOnlyProjectData{DisplayName = "Decision Trees", Description= "Initiated a decision tree project and expanded its capabilities by introducing random forest, bagging, and boosting techniques. This strategic enhancement was aimed at fine-tuning efficiency and accuracy."} },
            { "ModelsOfComputation", new TextOnlyProjectData{DisplayName = "Models of Computation", Description=  "Engaged in the study of Models of Computation, comprehending the theoretical foundations for Definite finite state machines and how they can be tools for simplifying and improving computational efficiency and redefining how we understand problems" } },
            { "LowLevelOptimization", new TextOnlyProjectData{DisplayName = "Low Level Optimization", Description=  "Delved into low-level optimizations, specifically exploring loop unrolling techniques and gaining insight into compiler optimizations for enhanced performance." } },
            { "AlphaBetaPruning", new TextOnlyProjectData{DisplayName = "Alpha Beta Pruning", Description=  "Implemented alpha-beta pruning algorithm to enhance the efficiency of a pac-man AI, optimizing decision-making processes by eliminating redundant search paths in the game tree." } },
            { "HackTheU", new TextOnlyProjectData{DisplayName = "Hack The U", Description=  "Hack The U 2019 - Used ERSI mapping API to gamify identification of real-world places.\r\nUseless Inventions Hackathon (2019) - Used REACT to make a text editor that deleted text. \r\nHack The U 2018 - Used ALGOLIA (a search API) to develop an app to organize/prioritize tasks; Award: Best Use of ALGOLIA."  } },
            { "WestonScienceScholars", new TextOnlyProjectData{DisplayName = "Weston Science Scholars", Description=  "Worked with a team of 4 to develop a small Android application to aid in data collection during field work.\r\n"  } },
            { "SingularityTurnTracker", new TextOnlyProjectData{DisplayName = "Singularity Turn Tracker", Description=  "Crafted a mod for the card game \"Singularity\" on Tabletop Simulator, enhancing gameplay for myself and friends. Utilized Lua code and XML to interface with the Tabletop Simulator API."  } },
            { "GameCraft", new TextOnlyProjectData{DisplayName = "Game Craft", Description=  "In the Game Craft club at the University of Utah, I worked in Unity to devise customizable floating and moving platforms for a straightforward platformer game. During game jams, I supported my team with file orgainization and collaborated with designers to integrate game components seamlessly and resolve bugs."  } },
            { "IDTech", new TextOnlyProjectData{DisplayName = "ID Tech", Description=  "Dove into JAVA programming through the implementation of Connect 4 and various other small-scale games. Additionally, delved into Minecraft personal mods, crafting custom blocks that yielded unique items such as a lightning-shooting sword, and introduced novel mechanics for spawning snow and iron golems."  } }
        };
    }


}
