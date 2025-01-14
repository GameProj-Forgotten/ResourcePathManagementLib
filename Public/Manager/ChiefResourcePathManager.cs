using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonUtilLib.ThreadSafe;


namespace ResourcePathManagementLib
{
    /// <summary>
    /// This class is a singleton class that manages the resource paths for the entire project.
    /// </summary>
    public sealed class ChiefResourcePathManager : SingleTon<ChiefResourcePathManager>, IDisposable
    {
        private readonly MapGenResourcePathData m_mapGenResourcePathData;


        /// <summary>
        /// Loads the resource paths for the entire project.
        /// </summary>
        public ChiefResourcePathManager()
        {
            m_mapGenResourcePathData = new MapGenResourcePathData();
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

        /// <summary>
        /// Disposes the resource paths for the entire project.
        /// </summary>
        public new void Dispose()
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