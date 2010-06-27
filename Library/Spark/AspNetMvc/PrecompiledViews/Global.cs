// Copyright 2008 Louis DeJardin - http://whereslou.com
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Spark.Web.Mvc;

namespace PrecompiledViews
{
    public partial class Global
    {
        public static void RegisterViewEngine(ViewEngineCollection engines)
        {
            engines.Add(new SparkViewFactory());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add(new Route("{controller}/{action}/{id}", new MvcRouteHandler())
                           {
                               Defaults = new RouteValueDictionary(new {action = "Index", id = ""}),
                           });

            routes.Add(new Route("Default.aspx", new MvcRouteHandler())
                           {
                               Defaults = new RouteValueDictionary(new {controller = "Home", action = "Index", id = ""}),
                           });
        }

        public static void LoadPrecompiledViews(ViewEngineCollection engines)
        {
            SparkViewFactory factory = engines.OfType<SparkViewFactory>().First();
            factory.Engine.LoadBatchCompilation(Assembly.Load("Precompiled"));
        }
    }
}