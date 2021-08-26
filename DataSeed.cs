using TestApp.API.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TestApp.API
{
    public class DataSeed
    {
        private readonly ApiContext _ctx;

        public DataSeed(ApiContext ctx)
        {
            _ctx = ctx;
        }

        public void SeedData()
        {
            if(!_ctx.Infos.Any())
            {
                SeedInfos();
                _ctx.SaveChanges();
                
            }
            if(!_ctx.Tips.Any())
            {
                SeedTips();
                _ctx.SaveChanges();
                
            }  
        }

        private void SeedInfos(){
            List<Info> infos = BuildInfoList();

            foreach(var info in infos)
            {
                _ctx.Infos.Add(info);
            }
        }

        private void SeedTips(){
            List<Tip> tips = BuildTipList();

            foreach(var tip in tips)
            {
                _ctx.Tips.Add(tip);
            }
        }

        private List<Info> BuildInfoList()
        {
            return new List<Info>()
            {
                new Info{
                    category = "ASP.NET",
                    label = "ASP.net Web Pages",
                    information = "Asp.net pages is an SPA application model (Single Page Application)",
                    DateTimeCreated = DateTime.Now,
                    DateTimeChanged = DateTime.Now
                },
                new Info{
                    category = "ASP.NET",
                    label = "ASP",
                    information = "ASP stands for Active Server Pages. ASP is a development framework for building web pages.",
                    DateTimeCreated = DateTime.Now,
                    DateTimeChanged = DateTime.Now
                },
                new Info{
                    category = "ASP.NET",
                    label = "Razor Markup",
                    information = "Razor is a simple markup syntax for embedding server code(c#) into Asp.net web pages. C# code blocks are enclosed in @{...}. Inline expressions (variables or functions) start with @.C# files have the extension.cshtml.",
                    DateTimeCreated = DateTime.Now,
                    DateTimeChanged = DateTime.Now
                },
                new Info{
                    category = "Angular",
                    label = "Components",
                    information = "Components are basically classes that interact with the .html file of the component, which gets displayed from the browser.",
                    DateTimeCreated = DateTime.Now,
                    DateTimeChanged = DateTime.Now
                },
                new Info{
                    category = "Angular",
                    label = "App.module.ts",
                    information = "Contains libraries which are imported and also a declarative which is assigned to the component.",
                    DateTimeCreated = DateTime.Now,
                    DateTimeChanged = DateTime.Now
                },
                new Info{
                    category = "SQL",
                    label = "Index",
                    information = "Indexes are used to retrieve data from the database more quickly than otherwise.",
                    DateTimeCreated = DateTime.Now,
                    DateTimeChanged = DateTime.Now
                },
                new Info{
                    category = "SQL",
                    label = "Primary Key Constraint",
                    information = "The primary Key Contstrant uniquely identifies each record in a table. Must contain UNIQUE values, and cannot contain NULL values.",
                    DateTimeCreated = DateTime.Now,
                    DateTimeChanged = DateTime.Now
                }
            };
            
        }

        private List<Tip> BuildTipList()
        {
            return new List<Tip>()
            {
                new Tip{
                    tipCategory = "ASP.NET",
                    tipLabel = "Avoid HTML Helpers,Use Tag Helpers",
                    tipInfo = "Tag Helpers are processed and rendered on the server.They are more HTML friendly and they remind of Angular's directives.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                 new Tip{
                    tipCategory = "ASP.NET",
                    tipLabel = "TypeScript",
                    tipInfo = "Types, Static type checking, IntelliSence, Interfaces, Strict null Check",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "ASP.NET",
                    tipLabel = "Tests",
                    tipInfo = "XUnit for tests, its extensible, flexible, open source and has a good vocabulary.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "Angular",
                    tipLabel = "AddClass,RemoveClass",
                    tipInfo = "Use renderer addClass, removeClass where possible. It will prevent too many change detection checks.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "Angular",
                    tipLabel = "Get, Set",
                    tipInfo = "Try to use get, set on Input() instead ngOnChanges. When you have many Inputs in the ngOnChanges, each if has to be checked.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "Angular",
                    tipLabel = "npm-check",
                    tipInfo = "Add npm-check once a month to keep your dependencies updated. It will definitely help you keep track of changes.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "Angular",
                    tipLabel = "npm audit",
                    tipInfo = "Run npm audit command once a month to check if any of the libraries has any vulnerabilities. It will help you keep your app secure.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "SQL",
                    tipLabel = "Format your code",
                    tipInfo = "Formatting is a visual characteristic of your code and it doesn't affect results. However it makes your code easier to debug and analyze.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "SQL",
                    tipLabel = "Follow the Order of Execution",
                    tipInfo = "Your query needs to follow the right steps to achieve the best result.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
                new Tip{
                    tipCategory = "SQL",
                    tipLabel = "Master Group By",
                    tipInfo = "The clause group by is one of the most frequently used in SQL. You can use it to aggregate data, and there are many ways to get it to work in powerful ways for you.",
                    tipDateTimeCreated = DateTime.Now,
                    tipDateTimeChanged = DateTime.Now
                },
   
            };
            
        }
    }
}