using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonUtilLib.ThreadSafe;


namespace ResourcePathManagementLib
{
    public sealed class ChiefResourcePathManager : SingleTon<ChiefResourcePathManager>, IDisposable
    {
        private MapGenResourcePathData m_mapGenResourcePathData;


        public ChiefResourcePathManager()
        {
            m_mapGenResourcePathData.Init();
        }
        ~ChiefResourcePathManager()
        {
            Dispose(false);
        }

        internal MapGenResourcePathData MapGenResourcePathData
        {
            get
            {
                return m_mapGenResourcePathData;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(in bool bisDispose)
        {
            if(bisDispose)
            {
                m_mapGenResourcePathData.Dispose();
            }
        }
    }
}