#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Reflection;

#endregion

namespace TestTask2
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            string tabName = "MyPanel";
            string panelName = "MyPanel";
            a.CreateRibbonTab(tabName);
            var panel = a.CreateRibbonPanel(tabName, panelName);
            var NewButton = new PushButtonData("FixateAllAxisAndLevels",
                "Fixate Axis/Levels", Assembly.GetExecutingAssembly().Location, "TestTask1.Command");
            var NewBtn = panel.AddItem(NewButton) as PushButton;
            return Result.Succeeded;
        }

        
        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
