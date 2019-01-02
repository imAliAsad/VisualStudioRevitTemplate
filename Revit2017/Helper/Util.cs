#region Namespaces
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
#endregion 

namespace $safeprojectname$
{
    public static class Util
    {
        #region Revit Addin Info

        public const string AddinButtonText = "$safeprojectname$\n Addin";
        public const string AddinButtonTooltip = "A New Addin";
        public static string ProjectName = "$safeprojectname$";
        public const string AddinRibbonTabName = "Custom Addin Tab";
        public const string AddinRibbonPanel = "Addins Panel";

        public const string ApplicationWindowTitle = "Revit Addin";
        public const int ApplicationWindowHeight = 350;
        public const int ApplicationWindowWidth = 400;
        public const bool IsApplicationWindowTopMost = true;

        #endregion
    }
}

