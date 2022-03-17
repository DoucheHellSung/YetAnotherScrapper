using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBrowser.Common.Plugins;
using YetAnotherScrapper.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Serialization;

namespace YetAnotherScrapper
{
    public class Plugin : BasePlugin<Plugin_Configuration>
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
           
        }
        //Change

        private Guid _id = new Guid("0A60512E-D75E-44E4-83CB-8B4A6ED5AC37");
        public override Guid Id
        {
            get { return _id; }
        }

        public override string Name => throw new NotImplementedException();
    }
}
