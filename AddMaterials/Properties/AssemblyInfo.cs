﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "Revit AddMaterials Add-In" )]
[assembly: AssemblyDescription( "Add materials from Excel spreadsheet to Revit project" )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Autodesk Inc." )]
[assembly: AssemblyProduct( "Revit AddMaterials Add-In" )]
[assembly: AssemblyCopyright( "Copyright 2014 © Jeremy Tammik Autodesk Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "321044f7-b0b2-4b1c-af18-e71a19252be0" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
// 2014-03-20 2014.0.0.0 migrated from Revit 2011 to Revit 2014
// 2014-03-29 2014.0.0.1 error message and reporting enhancements
// 2014-04-02 2014.0.0.2 usability enhancements by Alexander Ignatovich
// 2014-04-20 2015.0.0.2 migrated to Revit 2015
// 2014-04-20 2015.0.0.3 integrated fill pattern viewer benchmark
// 2015-11-04 2015.0.0.4 updated FillPatternViewerControlWpf.xaml.cs, merged pull request #1 by @kfpopeye
// 2015-11-04 2015.0.0.5 updated FillPatternViewerControlWpf.xaml.cs, merged pull request #3 by @kfpopeye
// 2015-11-04 2016.0.0.0 tested and migrated to Revit 2016
// 2019-06-07 2016.0.0.1 integrated pull request #4 by @ridespirals -- handle 0 or negative DashPatterns
// 2019-06-12 2020.0.0.0 flat migration to Revit 2020
// 2019-06-12 2020.0.0.1 implemented suggestion by Александр Пекшев: Replace FillPattern = "{Binding CutPattern}" with FillPattern = "{Binding CutPattern, IsAsync=True}" and drawing thumbnails can get even faster
//
[assembly: AssemblyVersion( "2020.0.0.1" )]
[assembly: AssemblyFileVersion( "2020.0.0.1" )]
