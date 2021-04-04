using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.IO;
using System.Reflection;

namespace Grimoire.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (resourceMan == null)
                {
                    resourceMan = new ResourceManager("Grimoire.Properties.Resources", typeof(Resources).Assembly);
                }
                return resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static string defaulttext => ResourceManager.GetString("defaulttext", resourceCulture);

        internal static string statementcmds => ResourceManager.GetString("statementcmds", resourceCulture);

        //internal static byte[] aqlitegrimoire => (byte[])ResourceManager.GetObject("testgrimoire", resourceCulture);
        internal static byte[] aqlitegrimoire => File.ReadAllBytes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "catgirl.swf"));

        //internal static byte[] aqlitegrimoire => (byte[])ResourceManager.GetObject("testgrimoire2", resourceCulture);

        //internal static byte[] aqlitegrimoire => (byte[])ResourceManager.GetObject("aqlitegrimoire", resourceCulture);

        internal Resources()
        {
        }
    }
}