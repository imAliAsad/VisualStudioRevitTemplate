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

        public const string AddinButtonText = "Default\n Addin";
        public const string AddinButtonTooltip = "New Addin";

        public const string AddinRibbonTabName = "Archcorp";
        public const string AddinRibbonPanel = "Architecture";

        public const string ApplicationWindowTitle = "Revit Addin";
        public const int ApplicationWindowHeight = 350;
        public const int ApplicationWindowWidth = 400;
        public const bool IsApplicationWindowTopMost = true;

        #endregion
    }
}

