using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResourcePathManagementLib
{
    internal struct MapGenResourcePathData
    {
        internal struct InputResourcePathData
        {
            internal string InputResourceBasePath;

            internal string AbstractInputResourcePath;
            internal string BasicPathGenerationInputResourcePath;
            internal string RegionSelectionInputResourcePath;
            internal string MiddleLayerInputResourcePath;
        }
        internal struct OutputResourcePathData
        {
            internal string OutputResourceBasePath;

            internal string BasicPathGenerationOutputResourcePath;
            internal string RegionSelectionOutputResourcePath;
            internal string MiddleLayerOutputResourcePath;
            internal string TileKindOutputResourcePath;
        }
        internal struct AgentBinaryResourcePathData
        {
            internal string AgentBinaryResourceBasePath;

            internal string AgentBinaryResourcePath;
        }
        internal struct GameSaveMetadataPathData
        {
            internal string GameSaveMetadataBasePath;

            internal string GameSaveMetadataPath;
        }


        internal InputResourcePathData InputResourcePath;
        internal OutputResourcePathData OutputResourcePath;
        internal AgentBinaryResourcePathData AgentBinaryResourcePath;
        internal GameSaveMetadataPathData GameSaveMetadataPath;
    }
}