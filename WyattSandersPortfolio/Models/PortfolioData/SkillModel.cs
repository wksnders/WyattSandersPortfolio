namespace WyattSandersPortfolio.Models.PortfolioData
{
    public enum Skill
    {
        None = 0,
        CSharp,
        Unity,
        Unreal,
        Lua,
        DevelopmentTools,
        SoftwareTesting,
        GameDesign,
        XML,
        MobileGames,
        Json,
        TestDrivenDevelopment,
        AgileDevelopment,
        Git,
        NetworkEngineering,
        Firebase,
        SolutionArchitecture,
        GameDevelopment,
        CSS,
        Html,
        DebuggingCode,
        Communication,
        CollabrativeProblemSolving,
        FullStackDevelopment,
        DataAnalysis,
        Leadership,
        ProcessImprovement,
        Java,
        CasualGames,
        Cplusplus,
        VBA,
        MIPS,
        Teamwork,
        Python,
        Django,
        ProjectPlanning,
        DataStructures,
        AsymtoticNotation,
        Algorithms,
        C,
        dotNetFramework,
        MySQL,
        postgresql,
        LINQ,
        Modding,
        CustomerService,
        MicrosoftExchange,
        MicrosoftOffice,
        MicrosoftExcel,
        ProblemSolving,
        React,
        Blazor,
        Javascript,
        Vue
    }
    public static class SkillModel
    {
        public static Dictionary<Skill, String> SkillsToDisplayString = new Dictionary<Skill, string> {
            { Skill.None, "Error skill is none"},
            { Skill.CSharp, "C#"},
            { Skill.Unity, "Unity"},
            { Skill.Unreal, "Unreal"},
            { Skill.Lua, "Lua"},
            { Skill.DevelopmentTools, "Development Tools"},
            { Skill.SoftwareTesting, "Software Testing"},
            { Skill.GameDesign, "Game Design"},
            { Skill.XML, "XML"},
            { Skill.MobileGames, "Mobile Games"},
            { Skill.Json, "JSON"},
            { Skill.TestDrivenDevelopment, "Test-Driven Development"},
            { Skill.AgileDevelopment, "Agile Development"},
            { Skill.Git, "Git"},
            { Skill.NetworkEngineering, "Network Engineering"},
            { Skill.Firebase, "Firebase"},
            { Skill.SolutionArchitecture, "Solution Architecture"},
            { Skill.GameDevelopment, "Game Development"},
            { Skill.CSS, "CSS"},
            { Skill.Html, "HTML"},
            { Skill.DebuggingCode, "Debugging Code"},
            { Skill.Communication, "Communication"},
            { Skill.CollabrativeProblemSolving, "Collaborative Problem Solving"},
            { Skill.FullStackDevelopment, "Full Stack Development"},
            { Skill.DataAnalysis, "Data Analysis"},
            { Skill.Leadership, "Leadership"},
            { Skill.ProcessImprovement, "Process Improvement"},
            { Skill.Java, "Java"},
            { Skill.CasualGames, "Casual Games"},
            { Skill.Cplusplus, "C++"},
            { Skill.VBA, "VBA"},
            { Skill.MIPS, "MIPS"},
            { Skill.Teamwork, "Teamwork"},
            { Skill.Python, "Python"},
            { Skill.Django, "Django"},
            { Skill.ProjectPlanning, "Project Planning"},
            { Skill.DataStructures, "Data Structures"},
            { Skill.AsymtoticNotation, "Asymptotic Notation"},
            { Skill.Algorithms, "Algorithms"},
            { Skill.C, "C"},
            { Skill.dotNetFramework, ".NET"},
            { Skill.MySQL, "MySQL"},
            { Skill.LINQ, "LINQ"},
            { Skill.Modding, "Modding"},
            { Skill.CustomerService, "Customer Service"},
            { Skill.MicrosoftExchange, "Microsoft Exchange"},
            { Skill.MicrosoftOffice, "Microsoft Office"},
            { Skill.MicrosoftExcel, "Microsoft Excel"},
            { Skill.ProblemSolving, "Problem Solving"},
            { Skill.React, "React"},
            { Skill.Blazor, "Blazor"},
            { Skill.Vue, "Vue"},
            { Skill.postgresql, "PostgreSQL"},
            { Skill.Javascript, "Javascript"}
        };
        public static Dictionary<Skill, String> SkillsToDisplayImg = new Dictionary<Skill, string> {
            { Skill.None, "Error skill is none"},
            { Skill.CSharp, "SVGs/Languages/csharp.svg"},
            { Skill.Unity, "SVGs/Languages/Unity.svg"},
            { Skill.Unreal, "SVGs/Languages/Unreal.svg"},
            { Skill.Lua, "SVGs/Languages/lua.svg"},
            { Skill.XML, "SVGs/Languages/XML.svg"},
            { Skill.Json, "SVGs/Languages/Json.svg"},
            { Skill.Git, "SVGs/Languages/Git.svg"},
            { Skill.Firebase, "SVGs/Languages/Firebase.svg"},
            { Skill.CSS, "SVGs/Languages/css.svg"},
            { Skill.Html, "SVGs/Languages/html.svg"},
            { Skill.Java, "SVGs/Languages/java.svg"},
            { Skill.Cplusplus, "SVGs/Languages/cpp.svg"},
            { Skill.VBA, "SVGs/Languages/VBA.svg"},
            { Skill.Python, "SVGs/Languages/python.svg"},
            { Skill.Django, "SVGs/Languages/Django.svg"},
            { Skill.C, "SVGs/Languages/c.svg"},
            { Skill.dotNetFramework, "SVGs/Languages/dotNetFramework.svg"},
            { Skill.MySQL, "SVGs/Languages/MySQL.svg"},
            { Skill.LINQ, "SVGs/Languages/LINQ.svg"},
            { Skill.React, "SVGs/Languages/React.svg"},
            { Skill.Blazor, "SVGs/Languages/Blazor.svg"},
            { Skill.postgresql, "SVGs/Languages/postgresql.svg"},
            { Skill.Javascript, "SVGs/Languages/javascript.svg"},
            { Skill.Vue, "SVGs/Languages/vue.svg"}
        };
        public static Dictionary<Skill, String> SkillsToHrefExample = new Dictionary<Skill, string> {
            
        };

        public static Dictionary<string, List<Skill>> SkillsByCategory = new Dictionary<string, List<Skill>>
        {
            { "Programming Languages And Tools", new List<Skill> { Skill.CSharp, Skill.Unity, Skill.Cplusplus,Skill.Unreal,
                Skill.Python,Skill.Django, Skill.Lua, Skill.Java,Skill.Javascript, Skill.CSS,Skill.Html,Skill.Vue, Skill.C,Skill.MySQL,Skill.postgresql, Skill.dotNetFramework, 
                Skill.LINQ, Skill.XML, Skill.Json, Skill.Git, Skill.Firebase, Skill.React,Skill.Blazor, Skill.VBA, } },
            { "Game Development", new List<Skill> { Skill.GameDesign, Skill.MobileGames, 
                Skill.GameDevelopment, Skill.CasualGames, Skill.Modding } },
            { "Software Engineering Practices", new List<Skill> { Skill.DataAnalysis,Skill.NetworkEngineering, Skill.SoftwareTesting, 
                Skill.TestDrivenDevelopment, Skill.AgileDevelopment, Skill.SolutionArchitecture, Skill.DataStructures, 
                Skill.AsymtoticNotation, Skill.Algorithms,Skill.DevelopmentTools,Skill.DebuggingCode } },
            { "Project Management and Planning", new List<Skill> { Skill.Communication, Skill.ProblemSolving, 
                Skill.CollabrativeProblemSolving, Skill.ProjectPlanning, Skill.Teamwork, Skill.Leadership, 
                Skill.ProcessImprovement } },
        };

        public static string GetDisplayStringForSkill( Skill skill){
            if (!SkillsToDisplayString.ContainsKey(skill)) 
            {
                return "Error skill not found";
            }
            return SkillsToDisplayString[skill];
        }

        public static bool TryGetDisplayImgForSkill(Skill skill, out string ImgPath)
        {
            ImgPath = "Error skill not found";
            if (!SkillsToDisplayImg.ContainsKey(skill))
            {
                return false;
            }
            ImgPath = SkillsToDisplayImg[skill];
            return true;
        }

        public static bool TryGetHrefForSkill(Skill skill, out string Href)
        {
            Href = "Error skill not found";
            if (!SkillsToHrefExample.ContainsKey(skill))
            {
                return false;
            }
            Href = SkillsToHrefExample[skill];
            return true;
        }
    }
}
